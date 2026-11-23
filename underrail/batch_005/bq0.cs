using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001E4D RID: 7757
[a1("Pickpocketing")]
[eiz("PS2")]
[Serializable]
public sealed class bq0 : r5, ISerializable
{
	// Token: 0x0600ABF0 RID: 44016 RVA: 0x003F7D18 File Offset: 0x003F5F18
	private bq0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(bq0);
		}
	}

	// Token: 0x0600ABF1 RID: 44017 RVA: 0x003F7D44 File Offset: 0x003F5F44
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600ABF2 RID: 44018 RVA: 0x003F7D50 File Offset: 0x003F5F50
	public override string fh()
	{
		return "Pickpocketing";
	}

	// Token: 0x0600ABF3 RID: 44019 RVA: 0x003F7D58 File Offset: 0x003F5F58
	public bq0(int A_0 = 0, ech A_1 = null) : base(A_0, A_1)
	{
	}

	// Token: 0x0600ABF4 RID: 44020 RVA: 0x003F7D64 File Offset: 0x003F5F64
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

	// Token: 0x0600ABF5 RID: 44021 RVA: 0x003F7D80 File Offset: 0x003F5F80
	protected override Dictionary<Type, float> fj()
	{
		return new Dictionary<Type, float>();
	}
}
