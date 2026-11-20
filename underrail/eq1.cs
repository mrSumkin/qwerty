using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001E44 RID: 7748
[a1("Mechanics")]
[eiz("MS2")]
[Serializable]
public sealed class eq1 : b3m, ISerializable
{
	// Token: 0x0600ABC7 RID: 43975 RVA: 0x003F79E0 File Offset: 0x003F5BE0
	private eq1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(eq1);
		}
	}

	// Token: 0x0600ABC8 RID: 43976 RVA: 0x003F7A0C File Offset: 0x003F5C0C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600ABC9 RID: 43977 RVA: 0x003F7A18 File Offset: 0x003F5C18
	public override string fh()
	{
		return "Mechanics";
	}

	// Token: 0x0600ABCA RID: 43978 RVA: 0x003F7A20 File Offset: 0x003F5C20
	public eq1(int A_0 = 0, ech A_1 = null) : base(A_0, A_1)
	{
	}

	// Token: 0x0600ABCB RID: 43979 RVA: 0x003F7A2C File Offset: 0x003F5C2C
	protected override Dictionary<Type, float> fj()
	{
		return new Dictionary<Type, float>();
	}
}
