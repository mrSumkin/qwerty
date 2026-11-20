using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001E3C RID: 7740
[a1("Thought Control")]
[eiz("MCS")]
[Serializable]
public sealed class dql : eoh, ISerializable
{
	// Token: 0x0600AB9F RID: 43935 RVA: 0x003F75FC File Offset: 0x003F57FC
	private dql(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(dql);
		}
	}

	// Token: 0x0600ABA0 RID: 43936 RVA: 0x003F7628 File Offset: 0x003F5828
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600ABA1 RID: 43937 RVA: 0x003F7634 File Offset: 0x003F5834
	public override string fh()
	{
		return "Thought Control";
	}

	// Token: 0x0600ABA2 RID: 43938 RVA: 0x003F763C File Offset: 0x003F583C
	public dql(int A_0 = 0, ech A_1 = null) : base(A_0, A_1)
	{
	}

	// Token: 0x0600ABA3 RID: 43939 RVA: 0x003F7648 File Offset: 0x003F5848
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

	// Token: 0x0600ABA4 RID: 43940 RVA: 0x003F7668 File Offset: 0x003F5868
	protected override Dictionary<Type, float> fj()
	{
		return new Dictionary<Type, float>
		{
			{
				typeof(fd),
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
