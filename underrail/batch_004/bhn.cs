using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001E10 RID: 7696
[a1("Persuasion")]
[eiz("PS6")]
[Serializable]
public sealed class bhn : fc, ISerializable
{
	// Token: 0x0600AA64 RID: 43620 RVA: 0x003F3CC4 File Offset: 0x003F1EC4
	private bhn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(bhn);
		}
	}

	// Token: 0x0600AA65 RID: 43621 RVA: 0x003F3CF0 File Offset: 0x003F1EF0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600AA66 RID: 43622 RVA: 0x003F3CFC File Offset: 0x003F1EFC
	public override string fh()
	{
		return "Persuasion";
	}

	// Token: 0x0600AA67 RID: 43623 RVA: 0x003F3D04 File Offset: 0x003F1F04
	public bhn(int A_0 = 0, ech A_1 = null) : base(A_0, A_1)
	{
	}

	// Token: 0x0600AA68 RID: 43624 RVA: 0x003F3D10 File Offset: 0x003F1F10
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

	// Token: 0x0600AA69 RID: 43625 RVA: 0x003F3D2C File Offset: 0x003F1F2C
	protected override Dictionary<Type, float> fj()
	{
		return new Dictionary<Type, float>
		{
			{
				typeof(e70),
				0.2f
			}
		};
	}
}
