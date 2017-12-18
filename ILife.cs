using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILife
{
    void m_Die();
    void m_Resurrect();
    void m_GainHealthPoints(float _howMuch);
    void m_LoseHealthPoints(float _howMuch);
}

//------------------------------------------------------

public abstract class LifeAdapter : MonoBehaviour, ILife
{
    public abstract void m_Die();
    public abstract void m_Resurrect();
    public abstract void m_GainHealthPoints(float _howMuch);
    public abstract void m_LoseHealthPoints(float _howMuch);
}
