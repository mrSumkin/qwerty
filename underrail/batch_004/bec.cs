using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001E48 RID: 7752
[a1("Intimidation")]
[eiz("IS1")]
[Serializable]
public sealed class bec : fc, ISerializable
{
	// Token: 0x0600ABD2 RID: 43986 RVA: 0x003F7A88 File Offset: 0x003F5C88
	private bec(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(bec);
		}
	}

	// Token: 0x0600ABD3 RID: 43987 RVA: 0x003F7AB4 File Offset: 0x003F5CB4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600ABD4 RID: 43988 RVA: 0x003F7AC0 File Offset: 0x003F5CC0
	public override string fh()
	{
		return "Intimidation";
	}

	// Token: 0x0600ABD5 RID: 43989 RVA: 0x003F7AC8 File Offset: 0x003F5CC8
	public bec(int A_0 = 0, ech A_1 = null) : base(A_0, A_1)
	{
	}

	// Token: 0x0600ABD6 RID: 43990 RVA: 0x003F7AD4 File Offset: 0x003F5CD4
	protected override Dictionary<Type, float> fi()
	{
		return new Dictionary<Type, float>
		{
			{
				typeof(d3m),
				1f
			},
			{
				typeof(axr),
				1f
			}
		};
	}

	// Token: 0x0600ABD7 RID: 43991 RVA: 0x003F7B08 File Offset: 0x003F5D08
	protected override Dictionary<Type, float> fj()
	{
		return new Dictionary<Type, float>
		{
			{
				typeof(bhn),
				0.1f
			}
		};
	}
}
