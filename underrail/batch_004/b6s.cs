using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001E3F RID: 7743
[a1("Biology")]
[eiz("BS")]
[Serializable]
public sealed class b6s : b3m, ISerializable
{
	// Token: 0x0600ABB0 RID: 43952 RVA: 0x003F780C File Offset: 0x003F5A0C
	private b6s(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(b6s);
		}
	}

	// Token: 0x0600ABB1 RID: 43953 RVA: 0x003F7838 File Offset: 0x003F5A38
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600ABB2 RID: 43954 RVA: 0x003F7844 File Offset: 0x003F5A44
	public override string fh()
	{
		return "Biology";
	}

	// Token: 0x0600ABB3 RID: 43955 RVA: 0x003F784C File Offset: 0x003F5A4C
	public b6s(int A_0 = 0, ech A_1 = null) : base(A_0, A_1)
	{
	}

	// Token: 0x0600ABB4 RID: 43956 RVA: 0x003F7858 File Offset: 0x003F5A58
	protected override Dictionary<Type, float> fj()
	{
		return new Dictionary<Type, float>
		{
			{
				typeof(ii),
				0.15f
			}
		};
	}
}
