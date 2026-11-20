using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02001AB3 RID: 6835
[eiz("BLTSE")]
[Serializable]
public sealed class c4x : els, ISerializable
{
	// Token: 0x0600943C RID: 37948 RVA: 0x003A59A0 File Offset: 0x003A3BA0
	private c4x(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600943D RID: 37949 RVA: 0x003A59AC File Offset: 0x003A3BAC
	public c4x(double A_0) : base(c4x.a, "Время пули", ci8.b)
	{
		base.Duration = d0u.b;
		base.Stacking = axm.b;
		base.Icon = "BulletTime";
		base.Power = Convert.ToInt32(A_0 * 100.0);
		base.StaticEffects.Add(new ejr(A_0));
	}

	// Token: 0x0600943E RID: 37950 RVA: 0x003A5A10 File Offset: 0x003A3C10
	public override string cb(ll A_0)
	{
		ejr ejr = Enumerable.FirstOrDefault<ejr>(Enumerable.OfType<ejr>(base.StaticEffects));
		double num = 0.0;
		if (ejr != null)
		{
			num = ejr.a;
		}
		return qv.a("StatusEffects/BulletTime", new object[]
		{
			Convert.ToInt32(num * 100.0)
		});
	}

	// Token: 0x040038FC RID: 14588
	public new static readonly string a = "bulletTime";
}
