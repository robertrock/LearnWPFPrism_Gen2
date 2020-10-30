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
            _regionManager.RegisterViewWithRegion("RegionNW", typeof(Views.SampleView));

            // add new views here
            _regionManager.RegisterViewWithRegion("RegionNE", typeof(Views.SampleView2));
            //_regionManager.RegisterViewWithRegion("RegionSW", typeof(Views.SampleView));
            //_regionManager.RegisterViewWithRegion("RegionSE", typeof(Views.SampleView));

        }
    }
}
