using Auto.CacheEntities.ElasticDoc;
using Auto.Commons.Extensions.EfCore;
using Auto.EFCore.Entities;
using System.Collections.Generic;

namespace Gbxx.WebApi.Utils {
    public class MySqlRepository : IMySqlRepository {
        private MysqlDbContext db;
        public MySqlRepository(MysqlDbContext mySqlDbContext) {
            this.db = mySqlDbContext;
        }
        public List<WebNews> GetList(int categoryid, int pageIndex = 1, int pageSize = 100000, int minId = 0) {
            var index = (pageIndex - 1) * pageSize;
            var sql = @"
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
SELECT
    1 SiteId,
	CONVERT ( b.id, CHAR ) NewsId,
	b.cate_id CategoryId,
CASE
		b.cate_id 
		WHEN 1 THEN  '社会'
		WHEN 2 THEN  '娱乐'
		WHEN 3 THEN  '游戏'
		WHEN 4 THEN  '体育'
		WHEN 11 THEN '汽车'
		WHEN 12 THEN '财经'
		WHEN 14 THEN '军事'
		WHEN 15 THEN '国际'
		WHEN 16 THEN '时尚'
		WHEN 17 THEN '历史'
		WHEN 19 THEN '养生'
		ELSE '推荐' 
	END CategoryName,
    (CASE WHEN FLOOR(2 + ( RAND() * 12 )) > 0  THEN concat( 'C', LPAD( FLOOR( 0 + ( RAND() * 12 )), 4, 0 )) 
                                               ELSE null
     END) SpecialCode,
	b.title NewsTitle,
    b.ptitle CustomTitle,
	b.author Author,
	b.tag Tags,
	c.info Contents,
	'' Curl,
	concat( 'https://pic.2v7qe.cn', b.thumbpic ) ImageThums,
	b.playimgpic ImagePaths,
	CONVERT ( FLOOR( -1 + ( RAND() * 1 )), SIGNED ) DisplayType,
	CONVERT ( FLOOR( 0 + ( RAND() * 2 )), SIGNED ) IsHot,
	CONVERT ( FLOOR( 1000+ ( RAND() * 200000 )), SIGNED ) VirtualAccessNumber,
	STR_TO_DATE( FROM_UNIXTIME( check_time, '%Y-%m-%d %H:%i:%s' ), '%Y-%m-%d %H:%i:%s' ) PushTime,
	b.`from` Source,	
	b.from_pic SourceLogo,
	b.source_url SourceAddress,
    255 CategorySort,
	255 SpecialSort,
    255 Sequence
FROM
	xwxx_toutiao b
	LEFT JOIN xwxx_toutiao_content c ON c.id = b.id 
WHERE
	b.isdel = 0 
	AND b.`STATUS` = 1 
	AND LENGTH( c.info ) > 0 
	AND b.cate_id in(1,2,3,4,11,12,14,15,16,17,19,23)
    AND b.id < " + minId + " ORDER BY b.id DESC LIMIT " + index + "," + pageSize + "; COMMIT;";
            var result = db.Database.SqlQuery<WebNews>(sql);
            return result;
        }
    }
}
