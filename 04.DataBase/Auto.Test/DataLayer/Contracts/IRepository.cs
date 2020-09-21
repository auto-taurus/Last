using System;
using System.Threading.Tasks;

namespace OnLineStoreCore.DataLayer.Contracts
{
	public interface IRepository : IDisposable
	{
		Int32 CommitChanges();

		Task<Int32> CommitChangesAsync();
	}
}
