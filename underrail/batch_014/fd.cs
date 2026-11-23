using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001E3D RID: 7741
[eiz("PS5")]
[a1("Psychokinesis")]
[Serializable]
public sealed class fd : eoh, ISerializable
{
	// Token: 0x0600ABA5 RID: 43941 RVA: 0x003F76BC File Offset: 0x003F58BC
	private fd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(fd);
		}
	}

	// Token: 0x0600ABA6 RID: 43942 RVA: 0x003F76E8 File Offset: 0x003F58E8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600ABA7 RID: 43943 RVA: 0x003F76F4 File Offset: 0x003F58F4
	public override string fh()
	{
		return "Psychokinesis";
	}

	// Token: 0x0600ABA8 RID: 43944 RVA: 0x003F76FC File Offset: 0x003F58FC
	public fd(int A_0 = 0, ech A_1 = null) : base(A_0, A_1)
	{
	}

	// Token: 0x0600ABA9 RID: 43945 RVA: 0x003F7708 File Offset: 0x003F5908
	protected override Dictionary<Type, float> fi()
	{
		return new Dictionary<Type, float>
		{
			{
				typeof(axr),
				1f
			}
		};
	}

	// Token: 0x0600ABAA RID: 43946 RVA: 0x003F7728 File Offset: 0x003F5928
	protected override Dictionary<Type, float> fj()
	{
		return new Dictionary<Type, float>
		{
			{
				typeof(dql),
				0.1f
			},
			{
				typeof(rs),
				0.1f
			},
			{
				typeof(p5),
				0.1f
			}
		};
	}
}
