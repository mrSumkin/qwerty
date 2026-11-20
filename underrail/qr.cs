using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001E0C RID: 7692
[a1("Tailoring")]
[eiz("TS1")]
[Serializable]
public sealed class qr : b3m, ISerializable
{
	// Token: 0x0600AA53 RID: 43603 RVA: 0x003F3AB0 File Offset: 0x003F1CB0
	private qr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(qr);
		}
	}

	// Token: 0x0600AA54 RID: 43604 RVA: 0x003F3ADC File Offset: 0x003F1CDC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600AA55 RID: 43605 RVA: 0x003F3AE8 File Offset: 0x003F1CE8
	public override string fh()
	{
		return "Tailoring";
	}

	// Token: 0x0600AA56 RID: 43606 RVA: 0x003F3AF0 File Offset: 0x003F1CF0
	public qr(int A_0 = 0, ech A_1 = null) : base(A_0, A_1)
	{
	}

	// Token: 0x0600AA57 RID: 43607 RVA: 0x003F3AFC File Offset: 0x003F1CFC
	protected override Dictionary<Type, float> fj()
	{
		return new Dictionary<Type, float>();
	}
}
