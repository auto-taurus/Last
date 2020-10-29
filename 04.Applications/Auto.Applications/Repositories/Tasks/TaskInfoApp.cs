using Auto.Applications.Contracts.Tasks;
using Auto.DataServices.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Auto.Applications.Repositories.Tasks {
    public partial class TaskInfoApp : ITaskInfoApp {
        private readonly IMemberIncomeRepository _IMemberIncomeRepository;
        public TaskInfoApp(IMemberIncomeRepository memberIncomeRepository) {
            this._IMemberIncomeRepository = memberIncomeRepository;
        }
        //public async Task<bool> AddTask(string code) {

        //}
    }
}
