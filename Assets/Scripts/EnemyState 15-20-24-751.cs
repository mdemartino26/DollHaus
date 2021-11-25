
public class EnemyState : State
{
    public AttackState attackState;
    public bool canSeeThePlayer; 
    public override State RunCurrentState()
    {
        if(canSeeThePlayer)
        {
            return attackState;
        } else {
            return this;
        }
    }

}
