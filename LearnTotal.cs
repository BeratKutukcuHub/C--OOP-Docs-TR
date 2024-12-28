using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConsole
{
    internal class LearnTotal : ILearnTotal
    {
        public LearnPolimorfizm LearnPolimorfizm { get; set; }
        public LearnAnonymousType LearnAnonymousType { get; set; }
        public LearnGenericType LearnGenericType { get; set; }
        public LearnAllWork LearnAllWork { get; set; }
        public LearnDelegateReturnType LearnDelegateReturnType { get; set; }
        public LearnCopyClassMembers LearnCopyClassMembers { get; set; }
        public LearnExtension LearnExtension { get; set; }
        public LearnThread LearnThread { get; set; }
        public LearnEntitesRepository LearnEntitesRepository { get; set; }
        public LearnRefOutKeyword LearnRefOutKeyword { get; set; }
        public LearnRecursive LearnRecursive { get; set; }

        public LearnTotal(LearnPolimorfizm learnPolimorfizm,
            LearnAnonymousType learnAnonymousType,
            LearnGenericType learnTypes, LearnAllWork learnAllWork,
            LearnDelegateReturnType learnDelegateReturnType,
            LearnCopyClassMembers learnCopyClassMembers,
            LearnExtension learnExtension,
            LearnThread learnThread,
            LearnEntitesRepository learnEntitesRepository,
            LearnRefOutKeyword learnRefOutKeyword, LearnRecursive learnRecursive)
        {
            LearnExtension = learnExtension;
            LearnThread = learnThread;
            LearnEntitesRepository = learnEntitesRepository;
            LearnPolimorfizm = learnPolimorfizm;
            LearnAnonymousType = learnAnonymousType;
            LearnGenericType = learnTypes;
            LearnAllWork = learnAllWork;
            LearnDelegateReturnType = learnDelegateReturnType;
            LearnCopyClassMembers = learnCopyClassMembers;
            LearnRefOutKeyword = learnRefOutKeyword;
            LearnRecursive = learnRecursive;
        }
    }
}
