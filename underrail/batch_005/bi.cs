using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02001FF9 RID: 8185
public sealed class bi : cao
{
	// Token: 0x0600C0F8 RID: 49400 RVA: 0x0042D9D4 File Offset: 0x0042BBD4
	public string d()
	{
		return this.a;
	}

	// Token: 0x0600C0F9 RID: 49401 RVA: 0x0042D9DC File Offset: 0x0042BBDC
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600C0FA RID: 49402 RVA: 0x0042D9E8 File Offset: 0x0042BBE8
	public string f()
	{
		return this.b;
	}

	// Token: 0x0600C0FB RID: 49403 RVA: 0x0042D9F0 File Offset: 0x0042BBF0
	public void b(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600C0FC RID: 49404 RVA: 0x0042D9FC File Offset: 0x0042BBFC
	public string b()
	{
		return this.c;
	}

	// Token: 0x0600C0FD RID: 49405 RVA: 0x0042DA04 File Offset: 0x0042BC04
	public void c(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600C0FE RID: 49406 RVA: 0x0042DA10 File Offset: 0x0042BC10
	public float? c()
	{
		return this.f;
	}

	// Token: 0x0600C0FF RID: 49407 RVA: 0x0042DA18 File Offset: 0x0042BC18
	public void a(float? A_0)
	{
		this.f = A_0;
	}

	// Token: 0x0600C100 RID: 49408 RVA: 0x0042DA24 File Offset: 0x0042BC24
	public int? g()
	{
		return this.g;
	}

	// Token: 0x0600C101 RID: 49409 RVA: 0x0042DA2C File Offset: 0x0042BC2C
	public void a(int? A_0)
	{
		this.g = A_0;
	}

	// Token: 0x0600C102 RID: 49410 RVA: 0x0042DA38 File Offset: 0x0042BC38
	public Color e()
	{
		return this.h;
	}

	// Token: 0x0600C103 RID: 49411 RVA: 0x0042DA40 File Offset: 0x0042BC40
	public void a(Color A_0)
	{
		this.h = A_0;
	}

	// Token: 0x0600C104 RID: 49412 RVA: 0x0042DA4C File Offset: 0x0042BC4C
	public bi()
	{
		this.i = bj8.a;
		this.a();
	}

	// Token: 0x0600C105 RID: 49413 RVA: 0x0042DA74 File Offset: 0x0042BC74
	public bi(string A_0, string A_1, string A_2, string A_3 = null, esj? A_4 = null)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
		if (A_4 != null)
		{
			this.i = A_4.Value;
		}
		else
		{
			this.i = bj8.a;
		}
		this.a();
	}

	// Token: 0x0600C106 RID: 49414 RVA: 0x0042DAE0 File Offset: 0x0042BCE0
	public override void iv(e6d A_0, cp9 A_1)
	{
		string text;
		if (!this.Enabled && !string.IsNullOrEmpty(this.d))
		{
			text = this.d;
		}
		else if (base.Pressed || base.Checked)
		{
			text = this.c;
		}
		else if (this.IsMousedOver)
		{
			text = this.b;
		}
		else
		{
			text = this.a;
		}
		if (!string.IsNullOrEmpty(text))
		{
			Vector2 vector = base.at().b();
			c3i c3i = ejh.b(text, A_1.a);
			if (c3i != null)
			{
				Color color = base.Color;
				if (this.f != null && !base.Checked)
				{
					color *= this.f.Value;
				}
				Rectangle a_ = new Rectangle((int)vector.X, (int)vector.Y, this.i.c, this.i.d);
				c3i.a(A_1, a_, color, 0, null);
			}
			if (this.g != null)
			{
				SpriteFont resource = A_1.a.GetResource<SpriteFont>(egg.p, null);
				if (resource != null)
				{
					string text2 = this.g.Value.ToString();
					Vector2 vector2 = resource.MeasureString(text2);
					Vector2 a_2 = new Vector2(vector.X + ((float)base.Size.c - vector2.X - 2f), vector.Y + ((float)base.Size.d - vector2.Y - 2f));
					A_1.b().xb(resource, text2, a_2, this.h);
				}
			}
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x0600C107 RID: 49415 RVA: 0x0042DCB0 File Offset: 0x0042BEB0
	private void a()
	{
		base.Size = this.i;
	}

	// Token: 0x040045C3 RID: 17859
	private new string a;

	// Token: 0x040045C4 RID: 17860
	private new string b;

	// Token: 0x040045C5 RID: 17861
	private new string c;

	// Token: 0x040045C6 RID: 17862
	private new string d;

	// Token: 0x040045C7 RID: 17863
	private new float e;

	// Token: 0x040045C8 RID: 17864
	private new float? f;

	// Token: 0x040045C9 RID: 17865
	private new int? g;

	// Token: 0x040045CA RID: 17866
	private Color h = Color.White;

	// Token: 0x040045CB RID: 17867
	private esj i;
}
