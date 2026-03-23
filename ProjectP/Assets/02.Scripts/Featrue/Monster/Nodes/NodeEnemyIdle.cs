using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

public class NodeEnemyIdle : EnemyBaseNode 
{
	[Output] public EnemyStateConnection exitToDamaged;
	[Output] public EnemyStateConnection exitToFollowingPlayer;
	[Output] public EnemyStateConnection exitToAttackPlayer;

	public override string Execute(EnemyBlackboard blackboard)
	{
		Debug.Log("지금은 Idle 상태 입니다?");
		if (blackboard.isDamaged) return "exitToDamaged";
		if (blackboard.isAttacking) return "exitToAttackPlayer";
		if (blackboard.isFollowing) return "exitToFollowingPlayer";
		return null;
	}

	public override string ToNodeName()
	{
		return "NodeEnemyIdle";
	}
}