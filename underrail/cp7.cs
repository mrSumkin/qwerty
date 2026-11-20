using System;
using System.Runtime.Serialization;

// Token: 0x02001AB2 RID: 6834
[eiz("SSSE2")]
[Serializable]
public sealed class cp7 : els, ISerializable
{
	// Token: 0x06009438 RID: 37944 RVA: 0x003A5938 File Offset: 0x003A3B38
	private cp7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009439 RID: 37945 RVA: 0x003A5948 File Offset: 0x003A3B48
	public cp7(int A_0, int A_1) : base(cp7.a, "Весёлая стрельба", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "xpbl_Abilities.25";
		base.MaxStacks = A_1;
		base.Stacking = axm.b;
	}

	// Token: 0x0600943A RID: 37946 RVA: 0x003A5988 File Offset: 0x003A3B88
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/ShootingSpree");
	}

	// Token: 0x040038FB RID: 14587
	public new static readonly string a = "shootingSpree";
}
