using Prism.Modularity;
using Prism.Regions;

namespace SampleModule
{
    public class SampleModule : IModule
    {
        private IRegionManager _regionManager;
    
        public SampleModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            // binding a region to a view
            _regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.SampleView)); 
        }
    }
}
