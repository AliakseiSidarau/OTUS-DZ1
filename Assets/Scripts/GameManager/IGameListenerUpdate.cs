namespace ShootEmUp
{
    public interface IGameListenerUpdate: IGameListener
    {
        void TickGame(float deltaTime);
    }
}