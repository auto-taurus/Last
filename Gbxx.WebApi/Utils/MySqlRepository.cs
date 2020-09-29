using Auto.Commons.Extensions.EfCore;
using Auto.Dto.ElasticDoc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Utils {
    public class MySqlRepository : IMySqlRepository {
        private MysqlDbContext db;
        public MySqlRepository(MysqlDbContext mySqlDbContext) {
            this.db = mySqlDbContext;
        }
        public List<NewsDoc> GetList(int pageIndex = 1, int pageSize = 100000, int minId = 0) {
            var index = (pageIndex - 1) * pageSize;
            var sql = @"
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
SELECT
	1,
	b.id NewsId,
	a.id CategoryId,
	a.`name` CategoryName,
	b.title NewsTitle,
	b.ptitle CustomTitle,
	b.author Author,
	b.tag Tags,
	c.info Contents,
	'' Curl,
	concat( 'https://pic.2v7qe.cn', b.thumbpic ) Img,
	b.playimgpic ImagePaths,
	CONVERT ( FLOOR( 0+ ( RAND() * 4 )), SIGNED ) DisplayType,
	CONVERT ( FLOOR( 0+ ( RAND() * 2 )), SIGNED ) IsHot,
	CONVERT ( FLOOR( 1000+ ( RAND() * 50001 )), SIGNED ) AccessCount,
	CAST(DATE_FORMAT(
		from_unixtime( unix_timestamp( '2020-01-01 00:00:00' ) + floor( rand() * ( unix_timestamp( '2020-09-27 23:59:59' ) - unix_timestamp( '2020-01-01 00:00:00' ) + 1 ) ) ),
		'%Y-%m-%d %H:%i:%s' 
		
	) AS datetime ) PushTime,
	b.`from` Source,
	b.from_pic SourceLogo,
	b.source_url SourceAddress,
	IFNULL( b.title, b.ptitle ) Title 
FROM
	xwxx_toutiao_cate a
	LEFT JOIN xwxx_toutiao b ON b.cate_id = a.id
	LEFT JOIN xwxx_toutiao_content c ON c.id = b.id 
	AND pid = 0 
WHERE
	b.isdel = 0 
	AND b.`STATUS` = 1 
	AND LENGTH( b.intro ) > 0 AND b.id < " + minId + " ORDER BY b.id DESC LIMIT " + index + "," + pageSize + "; COMMIT;";
            var result = db.Database.SqlQuery<NewsDoc>(sql);
            return result;
        }
    }
}
