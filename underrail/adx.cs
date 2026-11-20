using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001E4A RID: 7754
[a1("Hacking")]
[eiz("HS")]
[Serializable]
public sealed class adx : r5, ISerializable
{
	// Token: 0x0600ABDE RID: 43998 RVA: 0x003F7BA8 File Offset: 0x003F5DA8
	private adx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(adx);
		}
	}

	// Token: 0x0600ABDF RID: 43999 RVA: 0x003F7BD4 File Offset: 0x003F5DD4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600ABE0 RID: 44000 RVA: 0x003F7BE0 File Offset: 0x003F5DE0
	public override string fh()
	{
		return "Hacking";
	}

	// Token: 0x0600ABE1 RID: 44001 RVA: 0x003F7BE8 File Offset: 0x003F5DE8
	public adx(int A_0 = 0, ech A_1 = null) : base(A_0, A_1)
	{
	}

	// Token: 0x0600ABE2 RID: 44002 RVA: 0x003F7BF4 File Offset: 0x003F5DF4
	protected override Dictionary<Type, float> fi()
	{
		return new Dictionary<Type, float>
		{
			{
				typeof(av8),
				1f
			}
		};
	}

	// Token: 0x0600ABE3 RID: 44003 RVA: 0x003F7C10 File Offset: 0x003F5E10
	protected override Dictionary<Type, float> fj()
	{
		return new Dictionary<Type, float>
		{
			{
				typeof(ij),
				0.1f
			}
		};
	}
}
