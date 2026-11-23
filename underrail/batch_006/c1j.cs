using System;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000460 RID: 1120
public sealed class c1j : adt
{
	// Token: 0x06001D27 RID: 7463 RVA: 0x000A1A40 File Offset: 0x0009FC40
	private string a()
	{
		if (string.IsNullOrEmpty(this.e))
		{
			return ddq.a;
		}
		return this.e;
	}

	// Token: 0x06001D28 RID: 7464 RVA: 0x000A1A60 File Offset: 0x0009FC60
	public c1j(string A_0) : base(A_0)
	{
	}

	// Token: 0x06001D29 RID: 7465 RVA: 0x000A1A74 File Offset: 0x0009FC74
	public override void mc(TimeSpan A_0, double A_1)
	{
		this.f = null;
	}

	// Token: 0x06001D2A RID: 7466 RVA: 0x000A1A80 File Offset: 0x0009FC80
	public override ej1 aci(TimeSpan A_0, double A_1)
	{
		if (this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>(this.a(), null) == null)
		{
			this.a(A_0);
			return ej1.b;
		}
		if (this.f == null)
		{
			if (this.d != null)
			{
				this.f = new e4t(this.Subject.a8().h.b, this.d.Value, cux.a, 0, null, 1);
				this.Subject.a8().i.b.b(this.f, atp.a);
			}
			if (this.b != null)
			{
				string text = this.b;
				if (this.c > 0)
				{
					text += (cuo.a.Next(this.c) + 1).ToString();
				}
				this.Subject.a8().c().a("chitter", text, 1f, c9z.a, false, false);
			}
			if (this.d == null)
			{
				this.a(A_0);
				return ej1.b;
			}
		}
		else if (this.f.x() == dc4.e || this.f.x() == dc4.c || this.f.x() == dc4.d)
		{
			this.a(A_0);
			return ej1.b;
		}
		return ej1.a;
	}

	// Token: 0x06001D2B RID: 7467 RVA: 0x000A1BF4 File Offset: 0x0009FDF4
	private void a(TimeSpan A_0)
	{
		this.Subject.y6()[this.a()] = A_0 + TimeSpan.FromMilliseconds((0.5 + cuo.a.NextDouble()) * (double)this.a);
	}

	// Token: 0x06001D2C RID: 7468 RVA: 0x000A1C44 File Offset: 0x0009FE44
	public override bool acj(TimeSpan A_0, double A_1)
	{
		if (this.Subject.a8().h.b != null && !this.Subject.a8().h.b.aa().IsInControl)
		{
			return false;
		}
		TimeSpan? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>(this.a(), null);
		return (primitivePropertyValue == null || primitivePropertyValue.Value < A_0) && this.Subject.a8().h.b != null && this.Subject.a8().i.b != null;
	}

	// Token: 0x04001023 RID: 4131
	public int a = 60000;

	// Token: 0x04001024 RID: 4132
	public new string b;

	// Token: 0x04001025 RID: 4133
	public new int c;

	// Token: 0x04001026 RID: 4134
	public CharacterState? d;

	// Token: 0x04001027 RID: 4135
	public string e;

	// Token: 0x04001028 RID: 4136
	private e4t f;
}
