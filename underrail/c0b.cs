using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001E41 RID: 7745
[a1("Traps")]
[eiz("CS3")]
[Serializable]
public sealed class c0b : r5, ISerializable
{
	// Token: 0x0600ABBA RID: 43962 RVA: 0x003F78DC File Offset: 0x003F5ADC
	private c0b(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600ABBB RID: 43963 RVA: 0x003F78E8 File Offset: 0x003F5AE8
	public override string fh()
	{
		return "Traps";
	}

	// Token: 0x0600ABBC RID: 43964 RVA: 0x003F78F0 File Offset: 0x003F5AF0
	public c0b(int A_0 = 0, ech A_1 = null) : base(A_0, A_1)
	{
	}

	// Token: 0x0600ABBD RID: 43965 RVA: 0x003F78FC File Offset: 0x003F5AFC
	protected override Dictionary<Type, float> fi()
	{
		return new Dictionary<Type, float>
		{
			{
				typeof(cwu),
				1f
			}
		};
	}

	// Token: 0x0600ABBE RID: 43966 RVA: 0x003F7918 File Offset: 0x003F5B18
	protected override Dictionary<Type, float> fj()
	{
		return new Dictionary<Type, float>
		{
			{
				typeof(dca),
				0.1f
			},
			{
				typeof(eq1),
				0.1f
			}
		};
	}
}
