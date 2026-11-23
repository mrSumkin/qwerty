using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020012CD RID: 4813
[a(typeof(bim))]
[eiz("XMF")]
[cnn("TimelapseVertigo.Playfield.Design.Forms.ContainerAspectEditorForm, TimelapseVertigo.Playfield.Design")]
[Serializable]
public class czz : b0e, dex, ISerializable
{
	// Token: 0x06006A47 RID: 27207 RVA: 0x002CC988 File Offset: 0x002CAB88
	protected czz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (dbi)A_0.GetValue("XMF:IC", typeof(dbi));
		this.b = (ctz)A_0.GetValue("XMF:C", typeof(ctz));
		this.c = A_0.GetBoolean("XMF:I");
		this.d = A_0.GetBoolean("XMF:H");
		this.e = A_0.GetString("XMF:D");
		this.f = (A_0.GetValue("XMF:R", typeof(ar7)) as ar7);
	}

	// Token: 0x06006A48 RID: 27208 RVA: 0x002CCA3C File Offset: 0x002CAC3C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XMF:IC", this.a);
		info.AddValue("XMF:C", this.b);
		info.AddValue("XMF:I", this.c);
		info.AddValue("XMF:H", this.d);
		info.AddValue("XMF:D", this.e);
		info.AddValue("XMF:R", this.f);
	}

	// Token: 0x06006A49 RID: 27209 RVA: 0x002CCABC File Offset: 0x002CACBC
	public dbi air()
	{
		return this.a;
	}

	// Token: 0x06006A4A RID: 27210 RVA: 0x002CCAC4 File Offset: 0x002CACC4
	public void ais(dbi A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006A4B RID: 27211 RVA: 0x002CCAD0 File Offset: 0x002CACD0
	public ctz ait()
	{
		return this.b;
	}

	// Token: 0x06006A4C RID: 27212 RVA: 0x002CCAD8 File Offset: 0x002CACD8
	public void aiu(ctz A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006A4D RID: 27213 RVA: 0x002CCAE4 File Offset: 0x002CACE4
	public override d98 pr()
	{
		return d98.d;
	}

	// Token: 0x06006A4E RID: 27214 RVA: 0x002CCAE8 File Offset: 0x002CACE8
	public override void ps(d98 A_0)
	{
	}

	// Token: 0x06006A4F RID: 27215 RVA: 0x002CCAEC File Offset: 0x002CACEC
	public override bool af1()
	{
		return true;
	}

	// Token: 0x06006A50 RID: 27216 RVA: 0x002CCAF0 File Offset: 0x002CACF0
	public override void af2(bool A_0)
	{
	}

	// Token: 0x06006A51 RID: 27217 RVA: 0x002CCAF4 File Offset: 0x002CACF4
	public bool b()
	{
		return this.d;
	}

	// Token: 0x06006A52 RID: 27218 RVA: 0x002CCAFC File Offset: 0x002CACFC
	public void a(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06006A53 RID: 27219 RVA: 0x002CCB08 File Offset: 0x002CAD08
	public string a()
	{
		return this.e;
	}

	// Token: 0x06006A54 RID: 27220 RVA: 0x002CCB10 File Offset: 0x002CAD10
	public void a(string A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06006A55 RID: 27221 RVA: 0x002CCB1C File Offset: 0x002CAD1C
	public czz(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006A56 RID: 27222 RVA: 0x002CCB34 File Offset: 0x002CAD34
	protected override bool ww(c5x A_0, out string A_1)
	{
		if (!base.ww(A_0, out A_1))
		{
			return false;
		}
		if (base.a8().o.b == null)
		{
			A_1 = "stuck";
			return false;
		}
		if (!base.q())
		{
			foreach (ak1 a_ in base.a8().l)
			{
				if (aw1.a(null, a_, false, null))
				{
					A_1 = "Заблокировано";
					return false;
				}
			}
			return true;
		}
		return true;
	}

	// Token: 0x06006A57 RID: 27223 RVA: 0x002CCBE4 File Offset: 0x002CADE4
	protected override void af4(c5x A_0)
	{
		base.af4(A_0);
		if (Enumerable.FirstOrDefault<ak1>(base.a8().l) != null)
		{
			if (this.d)
			{
				base.a8().o.b.b = new Point(2, base.a8().o.b.b.Y);
				c5x c5x = new c5x();
				c5x.q("Тело");
				c5x.Layer = base.a8().Layer;
				c5x.Location = base.a8().Location;
				c5x.Size = base.a8().Size;
				c5x.VisualPriority = base.a8().VisualPriority + 1;
				c5x.SetAspect<cd0>(new cd0(c5x)
				{
					a = base.a8().o.b.a,
					b = new Point(3, base.a8().o.b.b.Y)
				});
				if (!string.IsNullOrEmpty(this.e))
				{
					bim bim = new bim(c5x);
					List<cze> list = bim.s();
					a72 a = new a72();
					a.b(this.e);
					list.Add(a);
					c5x.SetAspect<bim>(bim);
				}
				else
				{
					c5x.SetAspect<bim>(new c7j(c5x)
					{
						ContainerProtectionMode = this.b,
						ItemContainer = this.a,
						c = this.c
					});
				}
				c3g aspect = base.a8().GetAspect<c3g>();
				if (aspect != null)
				{
					c3g c3g = new c3g(c5x);
					aspect.a(c3g);
					c5x.SetAspect<c3g>(c3g);
				}
				base.a8().Area.a(c5x);
				this.f = new ar7(c5x);
			}
			else
			{
				base.a8().o.b.b = new Point(1, base.a8().o.b.b.Y);
			}
			base.a8().TileFormationModifiers.s3(1);
			base.a8().z();
		}
	}

	// Token: 0x06006A58 RID: 27224 RVA: 0x002CCE04 File Offset: 0x002CB004
	protected override void af5(c5x A_0)
	{
		base.af5(A_0);
		base.a8().TileFormationModifiers.s4(1);
		base.a8().z();
		base.a8().o.b.b = new Point(0, base.a8().o.b.b.Y);
		if (this.f != null && this.f.ao() != null)
		{
			this.f.ao().w();
			this.f.ao().an();
			this.f = null;
		}
	}

	// Token: 0x04002BAB RID: 11179
	private new dbi a = new dcw();

	// Token: 0x04002BAC RID: 11180
	private new ctz b;

	// Token: 0x04002BAD RID: 11181
	private bool c;

	// Token: 0x04002BAE RID: 11182
	private bool d;

	// Token: 0x04002BAF RID: 11183
	private string e;

	// Token: 0x04002BB0 RID: 11184
	private ar7 f;
}
