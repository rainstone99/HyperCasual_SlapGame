using UnityEngine;

public interface ISlapSystem
{
    void Hit();
    void Slap(ISlapSystem target);
}