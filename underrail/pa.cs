using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using Ouroboros.Playfield.Space;

// Token: 0x020012EB RID: 4843
[global::a(typeof(bim))]
[eiz("VSA")]
[Serializable]
public abstract class pa : bim, ISerializable
{
	// Token: 0x06006B7A RID: 27514 RVA: 0x002D2880 File Offset: 0x002D0A80
	protected pa(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("VSA:O");
		this.b = A_0.GetBoolean("VSA:C");
		this.c = A_0.GetInt32("VSA:S");
		this.d = A_0.GetInt32("VSA:T");
		this.e = (A_0.GetValue("VSA:I", typeof(Guid?)) as Guid?);
		this.f = A_0.GetString("VSA:A");
		if (ell.a() >= 681)
		{
			di7.ReadList<cze>("VSA:OOJ", ref this.g, A_0);
			di7.ReadList<cze>("VSA:OCJ", ref this.h, A_0);
		}
	}

	// Token: 0x06006B7B RID: 27515 RVA: 0x002D2958 File Offset: 0x002D0B58
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("VSA:O", this.a);
		info.AddValue("VSA:C", this.b);
		info.AddValue("VSA:S", this.c);
		info.AddValue("VSA:T", this.d);
		info.AddValue("VSA:I", this.e);
		info.AddValue("VSA:A", this.f);
		di7.WriteList<cze>("VSA:OOJ", this.g, info);
		di7.WriteList<cze>("VSA:OCJ", this.h, info);
	}

	// Token: 0x06006B7C RID: 27516 RVA: 0x002D29FC File Offset: 0x002D0BFC
	public bool m()
	{
		return this.a;
	}

	// Token: 0x06006B7D RID: 27517 RVA: 0x002D2A04 File Offset: 0x002D0C04
	public void b(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006B7E RID: 27518 RVA: 0x002D2A10 File Offset: 0x002D0C10
	public new bool k()
	{
		return this.b;
	}

	// Token: 0x06006B7F RID: 27519 RVA: 0x002D2A18 File Offset: 0x002D0C18
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006B80 RID: 27520 RVA: 0x002D2A24 File Offset: 0x002D0C24
	public int h()
	{
		return this.c;
	}

	// Token: 0x06006B81 RID: 27521 RVA: 0x002D2A2C File Offset: 0x002D0C2C
	public void b(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006B82 RID: 27522 RVA: 0x002D2A38 File Offset: 0x002D0C38
	public int b()
	{
		return this.d;
	}

	// Token: 0x06006B83 RID: 27523 RVA: 0x002D2A40 File Offset: 0x002D0C40
	public void a(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06006B84 RID: 27524 RVA: 0x002D2A4C File Offset: 0x002D0C4C
	public Guid? d()
	{
		return this.e;
	}

	// Token: 0x06006B85 RID: 27525 RVA: 0x002D2A54 File Offset: 0x002D0C54
	public void a(Guid? A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06006B86 RID: 27526 RVA: 0x002D2A60 File Offset: 0x002D0C60
	public string f()
	{
		return this.f;
	}

	// Token: 0x06006B87 RID: 27527 RVA: 0x002D2A68 File Offset: 0x002D0C68
	public void a(string A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06006B88 RID: 27528 RVA: 0x002D2A74 File Offset: 0x002D0C74
	public new List<cze> j()
	{
		return this.g;
	}

	// Token: 0x06006B89 RID: 27529 RVA: 0x002D2A7C File Offset: 0x002D0C7C
	public void b(List<cze> A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06006B8A RID: 27530 RVA: 0x002D2A88 File Offset: 0x002D0C88
	public List<cze> i()
	{
		return this.h;
	}

	// Token: 0x06006B8B RID: 27531 RVA: 0x002D2A90 File Offset: 0x002D0C90
	public void a(List<cze> A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06006B8C RID: 27532 RVA: 0x002D2A9C File Offset: 0x002D0C9C
	public pa g()
	{
		if (this.e != null)
		{
			if (this.i == null)
			{
				aud aud = null;
				if (!string.IsNullOrEmpty(this.f))
				{
					aud = base.a8().Zone.n(this.f);
				}
				if (aud == null)
				{
					aud = base.a8().Area;
				}
				this.i = new EntityAspectReference<pa, bim>(aud, this.e.Value);
			}
			return this.i.ao();
		}
		return null;
	}

	// Token: 0x06006B8D RID: 27533 RVA: 0x002D2B24 File Offset: 0x002D0D24
	public pa(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006B8E RID: 27534 RVA: 0x002D2B48 File Offset: 0x002D0D48
	public c9b b(amc A_0, coh A_1)
	{
		if (this.a)
		{
			return c9b.d;
		}
		if (A_0.aa().Skills.Get<dca>().g() < this.c)
		{
			return c9b.b;
		}
		this.a(true, false);
		this.ajy();
		return c9b.a;
	}

	// Token: 0x06006B8F RID: 27535 RVA: 0x002D2B94 File Offset: 0x002D0D94
	public void e()
	{
		this.a(true, false);
		this.ajy();
	}

	// Token: 0x06006B90 RID: 27536 RVA: 0x002D2BA4 File Offset: 0x002D0DA4
	public new void l()
	{
		this.a(false, false);
		this.ajy();
	}

	// Token: 0x06006B91 RID: 27537 RVA: 0x002D2BB8 File Offset: 0x002D0DB8
	public c9b a(amc A_0, coh A_1)
	{
		if (this.a)
		{
			return c9b.d;
		}
		if (A_0.aa().BaseAbilities.Strength < this.d)
		{
			return c9b.b;
		}
		this.a(true, true);
		this.ajy();
		return c9b.a;
	}

	// Token: 0x06006B92 RID: 27538 RVA: 0x002D2C00 File Offset: 0x002D0E00
	public c9b c(amc A_0, coh A_1)
	{
		if (!this.a)
		{
			return c9b.d;
		}
		if (!this.b)
		{
			return c9b.f;
		}
		if (A_0.aa().Skills.Get<dca>().g() < this.c)
		{
			return c9b.b;
		}
		this.a(false, false);
		this.ajy();
		return c9b.a;
	}

	// Token: 0x06006B93 RID: 27539 RVA: 0x002D2C58 File Offset: 0x002D0E58
	public override avd[] jz()
	{
		if (this.a)
		{
			return new avd[]
			{
				new avd("go", "Abilities.70", "Пролезть", "Пробраться на другую сторону."),
				new avd("look", "Abilities.80", "Посмотреть", "Посмотреть через отверстие.")
			};
		}
		return null;
	}

	// Token: 0x06006B94 RID: 27540 RVA: 0x002D2CB0 File Offset: 0x002D0EB0
	protected override void mz(c5x A_0, string A_1 = null)
	{
		if (A_0 != null && A_0.h.b != null)
		{
			if (A_0.h.b.aa().IsInCombat)
			{
				return;
			}
			if (this.a && A_1 != "look")
			{
				if (this.g() != null)
				{
					ak1 ak = this.a();
					if (ak != null)
					{
						foreach (b0b b0b in ak.Entities)
						{
							c5x c5x = (c5x)b0b;
							if (c5x.TileFormationModifiers.c(2L) || c5x.z != null)
							{
								if (A_0.h.b.aa() is e3q)
								{
									a7v.a(new vr(null, null, "Вентиляционная решётка заблокирована с другой стороны.", new Color?(adi.l), null));
									bmj.a(base.a8(), new d53("Вентиляционная решётка заблокирована с другой стороны.", adi.l, null, false));
								}
								return;
							}
						}
						base.a8().c().a("enter-exit", "VentilationShaftEnterExit", 1f, c9z.a, false, false);
						this.g().a8().c().a("enter-exit", "VentilationShaftEnterExit", 1f, c9z.a, false, false);
						a0l.a(A_0, this.g().a8().Area, new Vector3((float)ak.Location.X, (float)ak.Location.Y, 0f), new HorizontalDirection?(this.g().a8().VisualDirection), true);
						return;
					}
				}
			}
			else if (A_1 != "go" && this.g() != null)
			{
				ak1 ak2 = this.a();
				if (ak2 != null)
				{
					b0b b0b2 = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(ak2.Entities, new Func<b0b, bool>(pa.a.a.a)));
					if (b0b2 != null && A_0.i.b != null)
					{
						ps serviceOrThrow = bpo.GetServiceOrThrow<ps>();
						bx5 bx = new bx5(A_0);
						bx.l(new EventHandler<EventArgs>(this.a));
						A_0.i.b.a(bx, atp.a, true, false);
						serviceOrThrow.ana(b0b2, this, b14.b, 8, null, null);
					}
				}
			}
		}
	}

	// Token: 0x06006B95 RID: 27541 RVA: 0x002D2F3C File Offset: 0x002D113C
	protected override void m0(c5x A_0, c3g A_1, string A_2)
	{
		if (this.a)
		{
			base.m0(A_0, A_1, A_2);
		}
	}

	// Token: 0x06006B96 RID: 27542
	protected abstract void ajy();

	// Token: 0x06006B97 RID: 27543 RVA: 0x002D2F54 File Offset: 0x002D1154
	private ak1 a()
	{
		if (this.g() != null)
		{
			Vector3 vector = new Vector3((float)((int)this.g().a8().Location.X), (float)((int)this.g().a8().Location.Y), 0f);
			switch (this.g().a8().VisualDirection)
			{
			default:
				vector += new Vector3(0f, -1f, 0f);
				break;
			case HorizontalDirection.East:
				vector += new Vector3(1f, 0f, 0f);
				break;
			case HorizontalDirection.South:
				vector += new Vector3(0f, 1f, 0f);
				break;
			case HorizontalDirection.West:
				vector += new Vector3(-1f, 0f, 0f);
				break;
			}
			return this.g().a8().Area.a(vector.a());
		}
		return null;
	}

	// Token: 0x06006B98 RID: 27544 RVA: 0x002D3074 File Offset: 0x002D1274
	private void a(bool A_0, bool A_1 = false)
	{
		this.a = A_0;
		this.ajy();
		if (A_0)
		{
			this.b(null);
		}
		else
		{
			this.a(null);
		}
		if (A_1)
		{
			this.b = false;
		}
		if (this.g() != null)
		{
			this.g().a = A_0;
			this.g().ajy();
			if (A_1)
			{
				this.g().b = false;
			}
		}
	}

	// Token: 0x06006B99 RID: 27545 RVA: 0x002D30E8 File Offset: 0x002D12E8
	private void b(b0b A_0)
	{
		foreach (cze cze in this.g)
		{
			if (cze != null)
			{
				cze.ym(A_0, base.a8(), a3f.a(base.a8()));
			}
		}
		foreach (cze cze2 in this.g().g)
		{
			if (cze2 != null)
			{
				cze2.ym(A_0, base.a8(), a3f.a(base.a8()));
			}
		}
	}

	// Token: 0x06006B9A RID: 27546 RVA: 0x002D31BC File Offset: 0x002D13BC
	private void a(b0b A_0)
	{
		foreach (cze cze in this.h)
		{
			if (cze != null)
			{
				cze.ym(A_0, base.a8(), a3f.a(base.a8()));
			}
		}
		foreach (cze cze2 in this.g().h)
		{
			if (cze2 != null)
			{
				cze2.ym(A_0, base.a8(), a3f.a(base.a8()));
			}
		}
	}

	// Token: 0x06006B9B RID: 27547 RVA: 0x002D3290 File Offset: 0x002D1490
	[dcc("VSA:mOIC")]
	private void a(object A_0, EventArgs A_1)
	{
		if (A_0 is bx5)
		{
			bpo.GetServiceOrThrow<ps>().anb(this);
		}
	}

	// Token: 0x04002C20 RID: 11296
	private new bool a;

	// Token: 0x04002C21 RID: 11297
	private bool b;

	// Token: 0x04002C22 RID: 11298
	private int c;

	// Token: 0x04002C23 RID: 11299
	private int d;

	// Token: 0x04002C24 RID: 11300
	private Guid? e;

	// Token: 0x04002C25 RID: 11301
	private string f;

	// Token: 0x04002C26 RID: 11302
	private List<cze> g = new List<cze>();

	// Token: 0x04002C27 RID: 11303
	private List<cze> h = new List<cze>();

	// Token: 0x04002C28 RID: 11304
	[NonSerialized]
	private EntityAspectReference<pa, bim> i;

	// Token: 0x020012ED RID: 4845
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06006BA4 RID: 27556 RVA: 0x002D34A8 File Offset: 0x002D16A8
		internal bool a(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x04002C2A RID: 11306
		public static readonly pa.a a = new pa.a();

		// Token: 0x04002C2B RID: 11307
		public static Func<b0b, bool> b;
	}
}
