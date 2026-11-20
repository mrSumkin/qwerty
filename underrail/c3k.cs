using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02001AE5 RID: 6885
[eiz("PTCSE")]
[Serializable]
public sealed class c3k : els, ISerializable
{
	// Token: 0x0600952A RID: 38186 RVA: 0x003A8DF8 File Offset: 0x003A6FF8
	private c3k(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 594)
		{
			this.b = A_0.GetInt32("PTCSE:S");
		}
	}

	// Token: 0x0600952B RID: 38187 RVA: 0x003A8E24 File Offset: 0x003A7024
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PTCSE:S", this.b);
	}

	// Token: 0x0600952C RID: 38188 RVA: 0x003A8E40 File Offset: 0x003A7040
	public c3k(int A_0, int A_1, int A_2) : base(c3k.a, "Психо-временное сжатие", ci8.b)
	{
		this.b = A_2;
		base.Icon = "Psi.PsychotemporalContraction";
		base.Duration = A_0;
		base.StaticEffects.Add(new i0(c0o.f, false, false, false));
		base.StaticEffects.Add(new d9(A_1, true, false));
		base.StaticEffects.Add(new ba(c0o.e, false, false, false));
		this.y = "PTCSEEJ";
	}

	// Token: 0x0600952D RID: 38189 RVA: 0x003A8EC8 File Offset: 0x003A70C8
	public override string cb(ll A_0)
	{
		int num = 0;
		d9 d = Enumerable.FirstOrDefault<d9>(Enumerable.OfType<d9>(base.StaticEffects));
		if (d != null)
		{
			num = d.Amount;
		}
		return qv.a("StatusEffects/PsychotemporalContraction", new object[]
		{
			num,
			c0o.e,
			Convert.ToInt32(c0o.a(this.b) * 100.0)
		});
	}

	// Token: 0x0400396A RID: 14698
	public new static readonly string a = "PsychotemporalContraction";

	// Token: 0x0400396B RID: 14699
	public int b;
}
