using System;
using System.Collections.Generic;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x0200045A RID: 1114
public sealed class b9x : adt
{
	// Token: 0x06001D09 RID: 7433 RVA: 0x000A117C File Offset: 0x0009F37C
	public b9x(string A_0) : base(A_0)
	{
	}

	// Token: 0x06001D0A RID: 7434 RVA: 0x000A11A8 File Offset: 0x0009F3A8
	public override void mc(TimeSpan A_0, double A_1)
	{
		this.e = null;
	}

	// Token: 0x06001D0B RID: 7435 RVA: 0x000A11B4 File Offset: 0x0009F3B4
	public override ej1 aci(TimeSpan A_0, double A_1)
	{
		if (this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>(ddq.bu, null) == null)
		{
			this.a(A_0);
			return ej1.b;
		}
		if (this.e == null)
		{
			int num = 0;
			if (this.b > 1)
			{
				num = cuo.a.Next(this.b);
			}
			if (this.c.Count > num && this.d.Count > num)
			{
				CharacterState? characterState = this.d[num];
				if (characterState != null)
				{
					this.e = new e4t(this.Subject.a8().h.b, characterState.Value, cux.a, 0, null, 1);
					this.Subject.a8().i.b.b(this.e, atp.a);
				}
				string text = this.c[num];
				if (!string.IsNullOrEmpty(text))
				{
					this.Subject.a8().c().a("idleActionActivity", text, 1f, c9z.a, false, false);
				}
			}
			if (this.e == null)
			{
				this.a(A_0);
				return ej1.b;
			}
		}
		else if (this.e.x() == dc4.e || this.e.x() == dc4.c || this.e.x() == dc4.d)
		{
			this.a(A_0);
			return ej1.b;
		}
		return ej1.a;
	}

	// Token: 0x06001D0C RID: 7436 RVA: 0x000A1344 File Offset: 0x0009F544
	private void a(TimeSpan A_0)
	{
		this.Subject.y6()[ddq.bu] = A_0 + TimeSpan.FromMilliseconds((0.5 + cuo.a.NextDouble()) * (double)this.a);
	}

	// Token: 0x06001D0D RID: 7437 RVA: 0x000A1394 File Offset: 0x0009F594
	public override bool acj(TimeSpan A_0, double A_1)
	{
		TimeSpan? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>(ddq.bu, null);
		return (primitivePropertyValue == null || primitivePropertyValue.Value < A_0) && this.Subject.a8().h.b != null && this.Subject.a8().i.b != null;
	}

	// Token: 0x04001007 RID: 4103
	public int a = 60000;

	// Token: 0x04001008 RID: 4104
	public new int b;

	// Token: 0x04001009 RID: 4105
	public new List<string> c = new List<string>();

	// Token: 0x0400100A RID: 4106
	public List<CharacterState?> d = new List<CharacterState?>();

	// Token: 0x0400100B RID: 4107
	private e4t e;
}
