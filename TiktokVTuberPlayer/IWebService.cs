namespace TiktokVTuberPlayer
{
    interface IWebService
    {
        void StartListener(int port);
        void StopListener(int port);
    }
}
