using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001E40 RID: 7744
[eiz("CS2")]
[a1("Chemistry")]
[Serializable]
public sealed class ii : b3m, ISerializable
{
	// Token: 0x0600ABB5 RID: 43957 RVA: 0x003F7874 File Offset: 0x003F5A74
	private ii(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(ii);
		}
	}

	// Token: 0x0600ABB6 RID: 43958 RVA: 0x003F78A0 File Offset: 0x003F5AA0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600ABB7 RID: 43959 RVA: 0x003F78AC File Offset: 0x003F5AAC
	public override string fh()
	{
		return "Chemistry";
	}

	// Token: 0x0600ABB8 RID: 43960 RVA: 0x003F78B4 File Offset: 0x003F5AB4
	public ii(int A_0 = 0, ech A_1 = null) : base(A_0, A_1)
	{
	}

	// Token: 0x0600ABB9 RID: 43961 RVA: 0x003F78C0 File Offset: 0x003F5AC0
	protected override Dictionary<Type, float> fj()
	{
		return new Dictionary<Type, float>
		{
			{
				typeof(b6s),
				0.1f
			}
		};
	}
}
