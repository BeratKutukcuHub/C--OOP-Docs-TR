namespace ControlConsole
{
    internal class DIConsoleController
    {
        public ILearnTotal _learnTotal { get; set; }
        public DIConsoleController(LearnTotal learnTotal)
        {
            _learnTotal = learnTotal;
        }
        public void DIMain()
        {
            // _learnTotal.LearnRecursive.LearnRecursiveMain();
            _learnTotal.LearnRefOutKeyword.LearnRefOutKeywordMain();
            // _learnTotal.LearnAnonymousType.LearnAnonymousTypeMain();
            // _learnTotal.LearnPolimorfizm.LearnPolimorfizmMain();
            // _learnTotal.LearnGenericType.LearnGenericTypeMain();
            // _learnTotal.LearnAllWork.LearnAllWorkMain(12,23,Calculated.FlagCalculator.Çarpma);
            // _learnTotal.LearnDelegateReturnType.LearnDelegateReturnTypeMain();
            // _learnTotal.LearnCopyClassMembers.LeaLearnCopyClassMembersMain();
            // _learnTotal.LearnDelegateReturnType.LearnDelegateReturnTypeMain();
            // _learnTotal.LearnThread.Main(20, 35);
            // _learnTotal.LearnExtension.LearnExtensionMain(23, "Ahmet Kaya");
            // _learnTotal.LearnEntitesRepository.LearnFuncActionEntitiesMain();
        }
    }
    internal class Program 
    {
        
        public static void Main()
        {
            DIConsoleController dIConsoleController = new(new LearnTotal
            (new LearnPolimorfizm()
            , new LearnAnonymousType()
            , new LearnGenericType(new ProductRepository()),
            new LearnAllWork(new Calculated()),
            new LearnDelegateReturnType(),
            new LearnCopyClassMembers(new Repository<ProductDetail>(new ContextEntity<ProductDetail>())),
            new LearnExtension(),
            new LearnThread(),
            new LearnEntitesRepository(new RepositoryMain<ProductEntity>(new ContextEntities<ProductEntity>())),
            new LearnRefOutKeyword(),new LearnRecursive()));
            

            dIConsoleController.DIMain();
        }
    }
    
}