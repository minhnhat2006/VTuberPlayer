namespace VTuberPlayer
{
    interface ITiktokService
    {
        void StartListener(int port);
        void StopListener(int port);
    }
}
