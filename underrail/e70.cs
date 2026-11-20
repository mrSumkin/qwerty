using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001E49 RID: 7753
[eiz("MS3")]
[a1("Mercantile")]
[Serializable]
public sealed class e70 : fc, ISerializable
{
	// Token: 0x0600ABD8 RID: 43992 RVA: 0x003F7B24 File Offset: 0x003F5D24
	private e70(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(e70);
		}
	}

	// Token: 0x0600ABD9 RID: 43993 RVA: 0x003F7B50 File Offset: 0x003F5D50
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600ABDA RID: 43994 RVA: 0x003F7B5C File Offset: 0x003F5D5C
	public override string fh()
	{
		return "Mercantile";
	}

	// Token: 0x0600ABDB RID: 43995 RVA: 0x003F7B64 File Offset: 0x003F5D64
	public e70(int A_0 = 0, ech A_1 = null) : base(A_0, A_1)
	{
	}

	// Token: 0x0600ABDC RID: 43996 RVA: 0x003F7B70 File Offset: 0x003F5D70
	protected override Dictionary<Type, float> fi()
	{
		return new Dictionary<Type, float>
		{
			{
				typeof(av8),
				1f
			}
		};
	}

	// Token: 0x0600ABDD RID: 43997 RVA: 0x003F7B8C File Offset: 0x003F5D8C
	protected override Dictionary<Type, float> fj()
	{
		return new Dictionary<Type, float>
		{
			{
				typeof(bhn),
				0.2f
			}
		};
	}
}
