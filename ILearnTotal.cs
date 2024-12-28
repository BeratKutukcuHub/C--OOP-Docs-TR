using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConsole
{
    internal interface ILearnTotal
    {
        LearnPolimorfizm LearnPolimorfizm { get; set; }
        LearnAnonymousType LearnAnonymousType { get; set; }
        LearnGenericType LearnGenericType { get; set; }
        LearnAllWork LearnAllWork { get; set; }
        LearnDelegateReturnType LearnDelegateReturnType { get; set; }
        LearnCopyClassMembers LearnCopyClassMembers { get; set; }
        LearnExtension LearnExtension { get; set; }
        LearnThread LearnThread { get; set; }
        LearnEntitesRepository LearnEntitesRepository { get; set; }
        LearnRefOutKeyword LearnRefOutKeyword { get; set; }
        LearnRecursive LearnRecursive { get; set; }
    }
}
