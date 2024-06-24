using System.Threading.Tasks;

namespace TiktokVTuberPlayer
{
    interface ITiktokService
    {
        void StartListener();
        Task StopListenerAsync();
    }
}
