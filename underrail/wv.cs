using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Core.Logging;

// Token: 0x020012B3 RID: 4787
[a(typeof(bim))]
[eiz("SVEA")]
[Serializable]
public sealed class wv : b0e, ISerializable, bp1, csy, c98
{
	// Token: 0x0600691B RID: 26907 RVA: 0x002C5B18 File Offset: 0x002C3D18
	private wv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("SVEA:V", typeof(bcx)) as bcx);
		if (ell.a() >= 375)
		{
			this.b = (c44)A_0.GetValue("SVEA:P", typeof(c44));
		}
		if (ell.a() >= 385)
		{
			this.c = A_0.GetString("SVEA:M");
		}
		if (ell.a() >= 401)
		{
			this.d = (A_0.GetValue("SVEA:IVC", typeof(ae4)) as ae4);
			return;
		}
		this.d = new ae4();
	}

	// Token: 0x0600691C RID: 26908 RVA: 0x002C5BE4 File Offset: 0x002C3DE4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SVEA:V", this.a);
		info.AddValue("SVEA:P", this.b);
		info.AddValue("SVEA:M", this.c);
		info.AddValue("SVEA:IVC", this.d);
	}

	// Token: 0x0600691D RID: 26909 RVA: 0x002C5C44 File Offset: 0x002C3E44
	public bcx g()
	{
		return this.a;
	}

	// Token: 0x0600691E RID: 26910 RVA: 0x002C5C4C File Offset: 0x002C3E4C
	public void a(bcx A_0)
	{
		this.a = A_0;
		if (this.a != null)
		{
			this.a.k();
		}
	}

	// Token: 0x0600691F RID: 26911 RVA: 0x002C5C6C File Offset: 0x002C3E6C
	public int e()
	{
		if (this.a != null)
		{
			return this.a.v();
		}
		return 0;
	}

	// Token: 0x06006920 RID: 26912 RVA: 0x002C5C88 File Offset: 0x002C3E88
	public double h()
	{
		if (this.a != null)
		{
			return this.a.ag();
		}
		return 0.0;
	}

	// Token: 0x06006921 RID: 26913 RVA: 0x002C5CAC File Offset: 0x002C3EAC
	public c44 a()
	{
		return this.b;
	}

	// Token: 0x06006922 RID: 26914 RVA: 0x002C5CB4 File Offset: 0x002C3EB4
	public void a(c44 A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006923 RID: 26915 RVA: 0x002C5CC0 File Offset: 0x002C3EC0
	public string f()
	{
		return this.c;
	}

	// Token: 0x06006924 RID: 26916 RVA: 0x002C5CC8 File Offset: 0x002C3EC8
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006925 RID: 26917 RVA: 0x002C5CD4 File Offset: 0x002C3ED4
	public wv(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006926 RID: 26918 RVA: 0x002C5CE8 File Offset: 0x002C3EE8
	public override avd[] jz()
	{
		return new avd[]
		{
			new avd("drive", "Abilities.83", "Вождение", "Сесть за руль."),
			new avd("tinker", "Abilities.86", "Детали и багажник", "Доступ к двигателю под капотом и багажнику транспорта.")
		};
	}

	// Token: 0x06006927 RID: 26919 RVA: 0x002C5D28 File Offset: 0x002C3F28
	public override void mx()
	{
		base.mx();
		if (this.a != null)
		{
			this.a.k();
		}
		this.d();
	}

	// Token: 0x06006928 RID: 26920 RVA: 0x002C5D4C File Offset: 0x002C3F4C
	public override void my()
	{
		base.my();
		this.d.a(base.a8());
	}

	// Token: 0x06006929 RID: 26921 RVA: 0x002C5D68 File Offset: 0x002C3F68
	public void d()
	{
		if (this.a != null && base.a8() != null && base.a8().o.b != null)
		{
			if (!string.IsNullOrEmpty(this.c))
			{
				base.a8().o.b.a = this.c;
			}
			else
			{
				base.a8().o.b.a = "Objects\\Vehicles\\Ridable\\" + this.a.ah();
			}
			base.a8().o.b.b = new Point(base.a8().o.b.b.X, base.a8().ac);
			base.a8().q(this.a.an().d());
		}
	}

	// Token: 0x0600692A RID: 26922 RVA: 0x002C5E54 File Offset: 0x002C4054
	public bool ki(dbi A_0, coh A_1, object A_2)
	{
		return true;
	}

	// Token: 0x0600692B RID: 26923 RVA: 0x002C5E58 File Offset: 0x002C4058
	public bool kj(dbi A_0, coh A_1, object A_2)
	{
		return true;
	}

	// Token: 0x0600692C RID: 26924 RVA: 0x002C5E60 File Offset: 0x002C4060
	public void kk(dbi A_0, coh A_1, object A_2)
	{
		if (this.a != null)
		{
			this.a.k();
		}
		amc amc = A_2 as amc;
		if (amc != null && base.a8() != null && this.b >= c44.d)
		{
			c3g aspect = base.a8().GetAspect<c3g>();
			if (aspect != null && aspect.a(amc) && aspect.e())
			{
				a7v.a(new ehr("Ваши действия спровоцировали враждебность."));
			}
		}
	}

	// Token: 0x0600692D RID: 26925 RVA: 0x002C5EE0 File Offset: 0x002C40E0
	public void kl(dbi A_0, coh A_1, object A_2)
	{
		if (this.a != null)
		{
			this.a.k();
		}
		amc amc = A_2 as amc;
		if (amc != null && base.a8() != null && this.b >= c44.d)
		{
			c3g aspect = base.a8().GetAspect<c3g>();
			if (aspect != null && aspect.a(amc) && aspect.e())
			{
				a7v.a(new ehr("Ваши действия спровоцировали враждебность."));
			}
		}
	}

	// Token: 0x0600692E RID: 26926 RVA: 0x002C5F60 File Offset: 0x002C4160
	public void b(amc A_0)
	{
		if (A_0 != null && base.a8() != null && this.b >= c44.c)
		{
			c3g aspect = base.a8().GetAspect<c3g>();
			if (aspect != null && aspect.a(A_0) && aspect.e())
			{
				a7v.a(new ehr("Ваши действия спровоцировали враждебность."));
			}
		}
	}

	// Token: 0x0600692F RID: 26927 RVA: 0x002C5FC4 File Offset: 0x002C41C4
	public double a(int A_0)
	{
		return this.a.e(A_0);
	}

	// Token: 0x06006930 RID: 26928 RVA: 0x002C5FD4 File Offset: 0x002C41D4
	public bool b()
	{
		return this.h() < (double)this.e();
	}

	// Token: 0x06006931 RID: 26929 RVA: 0x002C5FE8 File Offset: 0x002C41E8
	public void a(amc A_0)
	{
		if (base.a8() != null)
		{
			c3g aspect = base.a8().GetAspect<c3g>();
			if (aspect != null)
			{
				aspect.a(A_0);
			}
		}
	}

	// Token: 0x06006932 RID: 26930 RVA: 0x002C601C File Offset: 0x002C421C
	public void r7(eds A_0)
	{
		this.d.a(base.a8(), this.g(), A_0.b.TotalMilliseconds);
	}

	// Token: 0x06006933 RID: 26931 RVA: 0x002C604C File Offset: 0x002C424C
	protected override void mz(c5x A_0, string A_1 = null)
	{
		if (A_1 == "tinker")
		{
			base.d(true);
			if (A_0 == null)
			{
				dux.b(LogSeverity.Error, "Null initiator attempted to a open vehicle ({0}).", new object[]
				{
					base.a8().ToString()
				});
			}
			ny aspect = A_0.GetAspect<ny>();
			if (aspect == null)
			{
				dux.b(LogSeverity.Error, "Initiator without action entity aspect attempted to a open vehicle ({0}).", new object[]
				{
					base.a8().ToString()
				});
			}
			this.af4(A_0);
			bx5 bx = new bx5(A_0);
			bx.l(new EventHandler<EventArgs>(this.a));
			aspect.a(bx, atp.a, true, false);
			a7v.a(new ed7(A_0, this));
			return;
		}
		if (A_0 != null && A_0.h.b != null)
		{
			string classPropertyValue = A_0.h.b.aa().CustomProperties.GetClassPropertyValue<string>(ddm.a);
			bool value = A_0.h.b.aa().CustomProperties.GetPrimitivePropertyValue<bool>(ddm.b, new bool?(false)).Value;
			if (!string.IsNullOrEmpty(classPropertyValue))
			{
				string text = "Вы не можете управлять чем-либо с этими когтями.";
				a7v.a(new h0(text + ".", new Color?(adi.m)));
				bmj.a(base.a8(), new d53(text, Color.Red, null, false));
				return;
			}
			if (value)
			{
				string text2 = "Вам понадобится больше гидроциклов.";
				a7v.a(new h0(text2 + ".", new Color?(adi.m)));
				bmj.a(base.a8(), new d53(text2, Color.Red, null, false));
				return;
			}
			if (A_0.h.b.aa().SpecialStates.b)
			{
				string text3 = "Вы не можете высадиться из транспорта в этом месте.";
				a7v.a(new h0(text3 + ".", new Color?(adi.m)));
				bmj.a(base.a8(), new d53(text3, Color.Red, null, false));
				return;
			}
			if (!this.a.al())
			{
				string text4 = "Транспорт не в рабочем состоянии";
				a7v.a(new h0(text4 + ".", new Color?(adi.m)));
				bmj.a(base.a8(), new d53(text4, Color.Red, null, false));
				return;
			}
			if (!this.a.b(A_0.h.b.aa()))
			{
				string text5 = "У вас нет ключа для зажигания";
				if (this.a.t() > 0)
				{
					text5 = text5 + " (взлом замков " + this.a.t().ToString() + ")";
				}
				a7v.a(new h0(text5 + ".", new Color?(adi.m)));
				bmj.a(base.a8(), new d53(text5, Color.Red, null, false));
				return;
			}
			if (A_0 != null && A_0.h.b != null && A_0.i.b != null)
			{
				awx awx = new awx();
				awx.a(m7.b);
				awx.a(false);
				if (A_0.h.b.aa().Vehicle != null)
				{
					awx.ad().Add(new a4s(new an9(), new ar7(A_0), null, null));
				}
				awx.ad().Add(new kp(this, A_0.h.b));
				A_0.i.b.b(awx, atp.a);
			}
		}
	}

	// Token: 0x06006934 RID: 26932 RVA: 0x002C63DC File Offset: 0x002C45DC
	protected override void m0(c5x A_0, c3g A_1, string A_2)
	{
		if (this.b != c44.a)
		{
			if (A_2 == "drive" || A_2 == null)
			{
				A_1.a(A_0.h.b);
				return;
			}
			if (A_2 == "tinker" && this.b == c44.e)
			{
				A_1.a(A_0.h.b);
				return;
			}
		}
		d2b aspect = base.a8().GetAspect<d2b>();
		if (aspect != null)
		{
			aspect.b(A_0.h.b);
		}
	}

	// Token: 0x06006935 RID: 26933 RVA: 0x002C6470 File Offset: 0x002C4670
	[dcc("SVEA:mOIC")]
	private void a(object A_0, EventArgs A_1)
	{
		bx5 bx = A_0 as bx5;
		if (bx != null && base.a8().Zone != null)
		{
			this.af5(bx.a());
		}
		base.d(false);
		a7v.a(new t9(bx.a(), this));
	}

	// Token: 0x04002B5E RID: 11102
	private new bcx a;

	// Token: 0x04002B5F RID: 11103
	private new c44 b;

	// Token: 0x04002B60 RID: 11104
	private string c;

	// Token: 0x04002B61 RID: 11105
	private ae4 d = new ae4();
}
