using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001E4C RID: 7756
[eiz("SS2")]
[a1("Stealth")]
[Serializable]
public sealed class a2n : r5, ISerializable
{
	// Token: 0x0600ABEA RID: 44010 RVA: 0x003F7CC8 File Offset: 0x003F5EC8
	private a2n(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600ABEB RID: 44011 RVA: 0x003F7CD4 File Offset: 0x003F5ED4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600ABEC RID: 44012 RVA: 0x003F7CE0 File Offset: 0x003F5EE0
	public override string fh()
	{
		return "Stealth";
	}

	// Token: 0x0600ABED RID: 44013 RVA: 0x003F7CE8 File Offset: 0x003F5EE8
	public a2n(int A_0 = 0, ech A_1 = null) : base(A_0, A_1)
	{
	}

	// Token: 0x0600ABEE RID: 44014 RVA: 0x003F7CF4 File Offset: 0x003F5EF4
	protected override Dictionary<Type, float> fi()
	{
		return new Dictionary<Type, float>
		{
			{
				typeof(dqg),
				1f
			}
		};
	}

	// Token: 0x0600ABEF RID: 44015 RVA: 0x003F7D10 File Offset: 0x003F5F10
	protected override Dictionary<Type, float> fj()
	{
		return new Dictionary<Type, float>();
	}
}
