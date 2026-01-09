namespace ShootEmUp
{
    public interface IGameListenerFixedUpdate: IGameListener
    {
        void FixedTickGame(float fixedDeltaTime);
    }
}