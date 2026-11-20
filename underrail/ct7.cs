using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001E38 RID: 7736
[eiz("PS3")]
[a1("Guns")]
[Serializable]
public sealed class ct7 : cxd, ISerializable
{
	// Token: 0x0600AB76 RID: 43894 RVA: 0x003F69F4 File Offset: 0x003F4BF4
	private ct7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600AB77 RID: 43895 RVA: 0x003F6A00 File Offset: 0x003F4C00
	public override string fh()
	{
		return "Guns";
	}

	// Token: 0x0600AB78 RID: 43896 RVA: 0x003F6A08 File Offset: 0x003F4C08
	public ct7(int A_0 = 0, ech A_1 = null) : base(A_0, A_1)
	{
	}

	// Token: 0x0600AB79 RID: 43897 RVA: 0x003F6A14 File Offset: 0x003F4C14
	protected override Dictionary<Type, float> fi()
	{
		return new Dictionary<Type, float>
		{
			{
				typeof(eav),
				1f
			}
		};
	}

	// Token: 0x0600AB7A RID: 43898 RVA: 0x003F6A30 File Offset: 0x003F4C30
	protected override Dictionary<Type, float> fj()
	{
		return new Dictionary<Type, float>
		{
			{
				typeof(e8k),
				0.75f
			}
		};
	}

	// Token: 0x0600AB7B RID: 43899 RVA: 0x003F6A4C File Offset: 0x003F4C4C
	public override string aib()
	{
		if (dk2.f())
		{
			if (dk2.e())
			{
				return "_full";
			}
			return "_xpbl";
		}
		else
		{
			if (dk2.e())
			{
				return "_xphw";
			}
			return null;
		}
	}
}
