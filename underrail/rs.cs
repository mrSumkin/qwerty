using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001E3E RID: 7742
[a1("Metathermics")]
[eiz("TCS")]
[Serializable]
public sealed class rs : eoh, ISerializable
{
	// Token: 0x0600ABAB RID: 43947 RVA: 0x003F777C File Offset: 0x003F597C
	private rs(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600ABAC RID: 43948 RVA: 0x003F7788 File Offset: 0x003F5988
	public override string fh()
	{
		return "Metathermics";
	}

	// Token: 0x0600ABAD RID: 43949 RVA: 0x003F7790 File Offset: 0x003F5990
	public rs(int A_0 = 0, ech A_1 = null) : base(A_0, A_1)
	{
	}

	// Token: 0x0600ABAE RID: 43950 RVA: 0x003F779C File Offset: 0x003F599C
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

	// Token: 0x0600ABAF RID: 43951 RVA: 0x003F77B8 File Offset: 0x003F59B8
	protected override Dictionary<Type, float> fj()
	{
		return new Dictionary<Type, float>
		{
			{
				typeof(dql),
				0.1f
			},
			{
				typeof(fd),
				0.1f
			},
			{
				typeof(p5),
				0.1f
			}
		};
	}
}
