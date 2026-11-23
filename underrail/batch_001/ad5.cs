using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Core.Logging;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Comm;

// Token: 0x0200145A RID: 5210
[eiz("SIA")]
[Serializable]
public abstract class ad5 : awx, b6p, ISerializable
{
	// Token: 0x06007547 RID: 30023 RVA: 0x0031AF40 File Offset: 0x00319140
	protected ad5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (eu7)A_0.GetValue("SIA:P", typeof(eu7));
			this.b = (ar7)A_0.GetValue("SIA:IR", typeof(ar7));
			this.c = (edx)A_0.GetValue("SIA:TTR", typeof(edx));
			this.d = (ar7)A_0.GetValue("SIA:ETR", typeof(ar7));
			if (ell.a() >= 9)
			{
				this.f = A_0.GetString("SIA:BCS");
				this.g = A_0.GetString("SIA:CS");
				this.h = A_0.GetString("SIA:CS2");
				this.i = A_0.GetString("SIA:CS3");
				this.j = A_0.GetString("SIA:CTS");
			}
			this.k = (A_0.GetValue("SIA:LIS", typeof(CharacterState?)) as CharacterState?);
			this.l = (A_0.GetValue("SIA:LIP", typeof(int?)) as int?);
			if (ell.a() >= 202)
			{
				this.m = A_0.GetString("SIA:WMV");
			}
			if (ell.a() >= 301)
			{
				this.n = (A_0.GetValue("SIA:CNV", typeof(float?)) as float?);
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(ad5))
			{
				this.a = (eu7)A_0.GetValue("_Proxy", typeof(eu7));
				this.b = (ar7)A_0.GetValue("_InvokerRef", typeof(ar7));
				this.c = (edx)A_0.GetValue("_TileTargetRef", typeof(edx));
				this.d = (ar7)A_0.GetValue("_EntityTargetRef", typeof(ar7));
				return;
			}
			this.a = (eu7)A_0.GetValue("SpellInvocationAction+_Proxy", typeof(eu7));
			this.b = (ar7)A_0.GetValue("SpellInvocationAction+_InvokerRef", typeof(ar7));
			this.c = (edx)A_0.GetValue("SpellInvocationAction+_TileTargetRef", typeof(edx));
			this.d = (ar7)A_0.GetValue("SpellInvocationAction+_EntityTargetRef", typeof(ar7));
		}
	}

	// Token: 0x06007548 RID: 30024 RVA: 0x0031B1FC File Offset: 0x003193FC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SIA:P", this.a);
		info.AddValue("SIA:IR", this.b);
		info.AddValue("SIA:TTR", this.c);
		info.AddValue("SIA:ETR", this.d);
		info.AddValue("SIA:BCS", this.f);
		info.AddValue("SIA:CS", this.g);
		info.AddValue("SIA:CS2", this.h);
		info.AddValue("SIA:CS3", this.i);
		info.AddValue("SIA:CTS", this.j);
		info.AddValue("SIA:LIS", this.k);
		info.AddValue("SIA:LIP", this.l);
		info.AddValue("SIA:WMV", this.m);
		info.AddValue("SIA:CNV", this.n);
	}

	// Token: 0x06007549 RID: 30025 RVA: 0x0031B300 File Offset: 0x00319500
	public override ci8? oi()
	{
		if (this.e() != null && this.e().p() != null)
		{
			return new ci8?(this.e().p().Nature);
		}
		return null;
	}

	// Token: 0x0600754A RID: 30026 RVA: 0x0031B348 File Offset: 0x00319548
	public eu7 e()
	{
		return this.a;
	}

	// Token: 0x0600754B RID: 30027 RVA: 0x0031B350 File Offset: 0x00319550
	public c5x q()
	{
		return this.b.ao() as c5x;
	}

	// Token: 0x0600754C RID: 30028 RVA: 0x0031B368 File Offset: 0x00319568
	public object h()
	{
		if (this.d != null)
		{
			return this.d.ao();
		}
		if (this.c != null)
		{
			return this.c.ao();
		}
		if (this.e != null)
		{
			return this.e.ao();
		}
		return null;
	}

	// Token: 0x0600754D RID: 30029
	protected abstract m7 d6();

	// Token: 0x0600754E RID: 30030 RVA: 0x0031B3BC File Offset: 0x003195BC
	public string n()
	{
		return this.f;
	}

	// Token: 0x0600754F RID: 30031 RVA: 0x0031B3C4 File Offset: 0x003195C4
	public string g()
	{
		return this.g;
	}

	// Token: 0x06007550 RID: 30032 RVA: 0x0031B3CC File Offset: 0x003195CC
	public string f()
	{
		return this.h;
	}

	// Token: 0x06007551 RID: 30033 RVA: 0x0031B3D4 File Offset: 0x003195D4
	public string m()
	{
		return this.i;
	}

	// Token: 0x06007552 RID: 30034 RVA: 0x0031B3DC File Offset: 0x003195DC
	public string p()
	{
		return this.j;
	}

	// Token: 0x06007553 RID: 30035 RVA: 0x0031B3E8 File Offset: 0x003195E8
	public override int? tm()
	{
		int? result = base.tm();
		if (result == null)
		{
			return this.l;
		}
		this.l = result;
		return result;
	}

	// Token: 0x06007554 RID: 30036 RVA: 0x0031B418 File Offset: 0x00319618
	public override CharacterState? q1()
	{
		CharacterState? result = base.q1();
		if (result == null)
		{
			return this.k;
		}
		this.k = result;
		return result;
	}

	// Token: 0x06007555 RID: 30037 RVA: 0x0031B448 File Offset: 0x00319648
	public string oj()
	{
		return this.m;
	}

	// Token: 0x06007556 RID: 30038 RVA: 0x0031B450 File Offset: 0x00319650
	public new void a(string A_0)
	{
		this.m = A_0;
	}

	// Token: 0x06007557 RID: 30039 RVA: 0x0031B45C File Offset: 0x0031965C
	public float? l()
	{
		return this.n;
	}

	// Token: 0x06007558 RID: 30040 RVA: 0x0031B464 File Offset: 0x00319664
	public ad5(eu7 A_0, c5x A_1, object A_2, bool A_3 = false)
	{
		czh.a(A_0, "proxy");
		czh.a(A_1, "invoker");
		czh.a(A_2, "target");
		this.a = A_0;
		this.b = new ar7(A_1);
		b0b b0b = A_2 as b0b;
		if (b0b != null)
		{
			this.d = new ar7(b0b);
		}
		else
		{
			ak1 ak = A_2 as ak1;
			if (ak != null)
			{
				this.c = new edx(ak);
			}
			else
			{
				coh coh = A_2 as coh;
				if (coh != null)
				{
					this.e = new cuj(this.a.s(), coh);
				}
			}
		}
		base.a(m7.c);
		base.b(true);
		base.c(true);
		if (!A_3)
		{
			this.r();
		}
	}

	// Token: 0x06007559 RID: 30041 RVA: 0x0031B530 File Offset: 0x00319730
	public bool d()
	{
		return this.a.yw();
	}

	// Token: 0x0600755A RID: 30042 RVA: 0x0031B540 File Offset: 0x00319740
	public bool b()
	{
		return this.a.r() && this.a.t();
	}

	// Token: 0x0600755B RID: 30043 RVA: 0x0031B560 File Offset: 0x00319760
	public bool o()
	{
		return this.a.o() && this.a.t();
	}

	// Token: 0x0600755C RID: 30044 RVA: 0x0031B580 File Offset: 0x00319780
	public void i()
	{
		if (this.h() != this.q() && (!(this.h() is ak1) || !(new Point((int)this.q().Location.X, (int)this.q().Location.Y) == ((ak1)this.h()).Location)))
		{
			Vector3? vector = null;
			b0b b0b = this.h() as b0b;
			if (b0b != null)
			{
				vector = new Vector3?(b0b.Location);
			}
			else
			{
				ak1 ak = this.h() as ak1;
				if (ak != null)
				{
					vector = new Vector3?(new Vector3((float)ak.Location.X, (float)ak.Location.Y, 0f));
				}
			}
			if (vector != null)
			{
				this.q().VisualDirection = bnx.a(this.q().Location, vector.Value);
			}
		}
	}

	// Token: 0x0600755D RID: 30045
	public abstract pl d7();

	// Token: 0x0600755E RID: 30046
	public abstract boa d8(afq A_0, params evd[] A_1);

	// Token: 0x0600755F RID: 30047 RVA: 0x0031B684 File Offset: 0x00319884
	public virtual cst d9(dqw A_0)
	{
		a3b a3b = this.u();
		CharacterState a_;
		if (a3b != null && a3b.f != null && a3b != null && Enum.TryParse<CharacterState>(a3b.f, out a_))
		{
			int a_2 = dz6.b((a3b.g != null) ? a3b.g.Value : cux.a);
			return new e4t(this.q().h.b, a_, a_2, 0, null, 1);
		}
		return null;
	}

	// Token: 0x06007560 RID: 30048 RVA: 0x0031B710 File Offset: 0x00319910
	public virtual b1z oq(dqw A_0)
	{
		a3b a3b = this.u();
		CharacterState characterState;
		if (a3b != null && Enum.TryParse<CharacterState>(a3b.c, out characterState))
		{
			int num;
			int num2;
			this.a(characterState, out num, out num2);
			int a_;
			if (a3b.d != null)
			{
				a_ = dz6.b(a3b.d.Value);
			}
			else
			{
				a_ = this.a(characterState);
			}
			return new e4t(this.q().h.b, characterState, a_, 0, new int?(num - 1), 1);
		}
		return null;
	}

	// Token: 0x06007561 RID: 30049 RVA: 0x0031B79C File Offset: 0x0031999C
	public new virtual b1z a(dqw A_0)
	{
		return null;
	}

	// Token: 0x06007562 RID: 30050 RVA: 0x0031B7A4 File Offset: 0x003199A4
	public virtual List<cst> ea(dqw A_0)
	{
		a3b a3b = this.u();
		CharacterState characterState;
		if (a3b != null && a3b.h != null && a3b != null && Enum.TryParse<CharacterState>(a3b.h, out characterState))
		{
			int a_ = dz6.b((a3b.i != null) ? a3b.i.Value : cux.a);
			return new List<cst>
			{
				new e4t(this.q().h.b, characterState, a_, 0, null, 1)
			};
		}
		if (a3b != null && a3b.c != null && a3b != null && Enum.TryParse<CharacterState>(a3b.c, out characterState))
		{
			int a_2 = this.a(characterState);
			int num;
			int num2;
			this.a(characterState, out num, out num2);
			return new List<cst>
			{
				new e4t(this.q().h.b, characterState, a_2, num, new int?(num + num2 - 1), 1)
			};
		}
		return null;
	}

	// Token: 0x06007563 RID: 30051 RVA: 0x0031B8AC File Offset: 0x00319AAC
	public virtual void op()
	{
		double num = this.e().i();
		if (num > 0.0)
		{
			coh coh = this.e().b9() as coh;
			if (coh != null)
			{
				coh.Battery = Math.Max(0.0, coh.Battery - num);
			}
		}
		int num2 = this.e().d(this.h());
		bool a_ = this.e().v() != dsk.d;
		if (num2 > 0)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null && service.ahg())
			{
				d4n d4n = service.ahu(this.e().b8());
				if (d4n != null)
				{
					d4n.a(num2, a_);
					return;
				}
			}
			else
			{
				dz6.a(this.e().b8(), num2, false, 2000, false, false);
			}
		}
	}

	// Token: 0x06007564 RID: 30052 RVA: 0x0031B98C File Offset: 0x00319B8C
	public virtual void t()
	{
		double num = this.e().f();
		coh coh = this.e().b9() as coh;
		if (coh != null)
		{
			coh.Battery = Math.Max(0.0, coh.Battery - num);
		}
	}

	// Token: 0x06007565 RID: 30053 RVA: 0x0031B9D8 File Offset: 0x00319BD8
	public dqw c()
	{
		return dpo.b(this.a);
	}

	// Token: 0x06007566 RID: 30054 RVA: 0x0031B9E8 File Offset: 0x00319BE8
	[dcc("SIA:mOF")]
	protected new virtual void a(object A_0, EventArgs A_1)
	{
	}

	// Token: 0x06007567 RID: 30055 RVA: 0x0031B9EC File Offset: 0x00319BEC
	protected virtual c47 eb()
	{
		return null;
	}

	// Token: 0x06007568 RID: 30056 RVA: 0x0031B9F0 File Offset: 0x00319BF0
	protected virtual c47 ec()
	{
		return null;
	}

	// Token: 0x06007569 RID: 30057 RVA: 0x0031B9F8 File Offset: 0x00319BF8
	protected new void a(CharacterState A_0, out int A_1, out int A_2)
	{
		if (this.q() != null && this.q().h.b != null && this.e() != null)
		{
			am5 am;
			if (this.m != null)
			{
				this.q().h.b.e(this.m).a.TryGetValue(A_0, out am);
			}
			else
			{
				this.q().h.b.e.TryGetValue(A_0, out am);
			}
			A_1 = (int)Math.Ceiling((double)am.a / 2.0);
			if (A_1 == am.a / 2)
			{
				A_1++;
			}
			A_2 = am.a - A_1;
			return;
		}
		A_1 = 0;
		A_2 = 0;
	}

	// Token: 0x0600756A RID: 30058 RVA: 0x0031BAC8 File Offset: 0x00319CC8
	protected new int a(CharacterState A_0)
	{
		if (A_0 == CharacterState.Throw)
		{
			return dz6.b(cux.i);
		}
		if (A_0 == CharacterState.Attack1 || A_0 == CharacterState.Attack2)
		{
			return dz6.b(cux.m);
		}
		if (A_0 == CharacterState.FinishPsi)
		{
			return dz6.b(cux.j);
		}
		return dz6.b(cux.a);
	}

	// Token: 0x0600756B RID: 30059 RVA: 0x0031BB20 File Offset: 0x00319D20
	protected a3b u()
	{
		efk a_ = null;
		c5x c5x = this.h() as c5x;
		if (c5x != null && c5x.h.b != null)
		{
			a_ = c5x.h.b.aa();
		}
		return this.e().h().bl(this.e(), a_);
	}

	// Token: 0x0600756C RID: 30060 RVA: 0x0031BB7C File Offset: 0x00319D7C
	protected void r()
	{
		dqw dqw = this.c();
		if (dqw == null)
		{
			dux.b(LogSeverity.Error, rz.f, new object[]
			{
				this.q().ToString(),
				this.a.ToString(),
				this.h().ToString()
			});
			return;
		}
		if (this.q().h.b == null)
		{
			dux.b(LogSeverity.Error, "Failed to initialize spell invocation action. The invoker must have Character Entity aspect. " + this.a(), new object[0]);
			return;
		}
		m7? m = dqw.rw();
		if (m != null)
		{
			base.a(base.kh() | m.Value);
		}
		else
		{
			base.a(base.kh() | this.d6());
		}
		this.h = dqw.sc(this.q(), this.e());
		this.f = dqw.sd(this.q(), this.e());
		this.g = dqw.aiv(this.q(), this.e());
		this.i = dqw.auh(this.q(), this.e());
		this.j = dqw.aui(this.q(), this.e());
		this.n = dqw.aqk();
		this.m = dqw.adi(this.q(), this.e());
		List<byte> list = dqw.sb();
		float num = dqw.ae9(this.h()) ?? this.a.c(this.h());
		if (this.h() != this.q() && !this.e().l() && (this.h() is ak1 || this.h() is b0b))
		{
			if (this.q().k.b != null)
			{
				if (num == as3.bk)
				{
					fk fk = new fk(this.q().k.b, this.h(), dqw.ae8(this.h()), dqw.afa(), this.e().m());
					fk.l();
					base.ad().Add(fk);
				}
				else
				{
					e1i e1i = new e1i(this.q().k.b, this.h(), num);
					e1i.l();
					if (list != null)
					{
						e1i.e().AddRange(list);
					}
					base.ad().Add(e1i);
				}
			}
			else
			{
				base.ad().Add(new ch8(this));
			}
		}
		aq8 item = new aq8(new gu(), this);
		base.ad().Add(item);
		if (this.e().v() == dsk.a)
		{
			base.ad().Add(new aro(this.q().h.b));
		}
		CombatSpeakEvent[] array = dqw.b6(this.q().h.b);
		if (array != null && array.Length != 0)
		{
			ap9 a_ = null;
			if (this.d != null)
			{
				c5x c5x = this.d.ao() as c5x;
				if (c5x != null && c5x.h.b != null)
				{
					a_ = new ap9(c5x.h.b.aa());
				}
			}
			base.ad().Add(new a0f(this.q(), a_, array));
		}
		int num2 = this.a.a(this.h());
		auv auv = this.d9(dqw);
		if (auv != null)
		{
			base.ad().Add(auv);
		}
		c47 c = this.eb();
		if (c != null)
		{
			eyx eyx = c as eyx;
			if (eyx != null)
			{
				bey.a(eyx, this.e().b8(), this.q().h.b);
			}
			anw item2 = new anw(c);
			base.ad().Add(item2);
		}
		if (num2 > 0)
		{
			pl pl = this.d7();
			if (pl != null)
			{
				pl pl2 = pl;
				pl2.a(pl2.kh() | dqw.e0());
				base.ad().Add(pl);
				base.a(base.kh() | m7.b);
			}
		}
		evd[] a_2 = null;
		if (this.h() != this.q() && !this.e().l())
		{
			evd evd;
			if (this.h() is coh)
			{
				evd = new bal(new cuj(new dsx(), (coh)this.h()));
			}
			else if (num == as3.bk)
			{
				evd = new dc9(dqw.ae8(this.h()), this.e().m());
			}
			else
			{
				e71 e = new e71(dqw.ae9(this.h()));
				if (list != null)
				{
					e.AdditionalObstructors.AddRange(list);
				}
				evd = e;
			}
			aq8 item3 = new aq8(evd, this);
			base.ad().Add(item3);
			a_2 = new evd[]
			{
				evd
			};
		}
		b1z b1z = this.oq(dqw);
		if (b1z != null)
		{
			base.ad().Add(new ch8(this));
			base.ad().Add(b1z);
			base.a(base.kh() | m7.b);
		}
		dvt item4 = new dvt(this.e());
		dea dea = new dea(this);
		dea.vh(this);
		if (!dqw.w1())
		{
			base.ad().Add(item4);
		}
		if (!dqw.w2())
		{
			base.ad().Add(dea);
		}
		c47 c2 = this.ec();
		if (c2 != null)
		{
			eyx eyx2 = c2 as eyx;
			if (eyx2 != null)
			{
				bey.a(eyx2, this.e().b8(), this.q().h.b);
			}
			anw item5 = new anw(c2);
			base.ad().Add(item5);
		}
		if (!string.IsNullOrEmpty(this.h))
		{
			bfq bfq = new bfq();
			bfq.b(Guid.NewGuid().ToString());
			bfq.c(this.h);
			bfq.a(bvl.c);
			base.ad().Add(new a4s(bfq, null, new ar7(this.q()), null));
		}
		b1z b1z2 = this.a(dqw);
		if (b1z2 != null)
		{
			base.ad().Add(new ch8(this));
			base.ad().Add(b1z2);
			base.a(base.kh() | m7.b);
		}
		afq afq = dqw.ba();
		if (afq != null)
		{
			afq.vh(this);
			base.ad().Add(afq);
		}
		if (dqw.w1())
		{
			base.ad().Add(item4);
		}
		if (dqw.w2())
		{
			base.ad().Add(dea);
		}
		if (this.e().v() == dsk.b)
		{
			base.ad().Add(new aro(this.q().h.b));
		}
		if (this.a.e() > 0)
		{
			afq afq2 = dqw.g3();
			if (afq2 != null)
			{
				afq2.vh(this);
				afq afq3 = dqw.aug();
				afq afq4 = dqw.ml();
				afq afq5 = dqw.ol();
				if (afq3 != null)
				{
					afq3.vh(this);
				}
				if (afq4 != null)
				{
					afq4.vh(this);
				}
				if (afq5 != null)
				{
					afq5.vh(this);
				}
				base.ad().Add(new d5g(this, afq3, afq2, afq4, afq5, a_2));
			}
			base.a(base.kh() | m7.b);
		}
		List<cst> list2 = this.ea(dqw);
		if (list2 != null)
		{
			foreach (cst item6 in list2)
			{
				base.ad().Add(item6);
				base.a(base.kh() | m7.b);
			}
		}
		base.q(new EventHandler<EventArgs>(this.a));
	}

	// Token: 0x0600756D RID: 30061 RVA: 0x0031C3C4 File Offset: 0x0031A5C4
	private new string a()
	{
		return string.Format("(Invoker: '{0}', Proxy: '{1}', Target: '{2}')", this.q().ToString(), this.a.ToString(), this.h().ToString());
	}

	// Token: 0x04003003 RID: 12291
	private new eu7 a;

	// Token: 0x04003004 RID: 12292
	private ar7 b;

	// Token: 0x04003005 RID: 12293
	private edx c;

	// Token: 0x04003006 RID: 12294
	private ar7 d;

	// Token: 0x04003007 RID: 12295
	private cuj e;

	// Token: 0x04003008 RID: 12296
	private string f;

	// Token: 0x04003009 RID: 12297
	private string g;

	// Token: 0x0400300A RID: 12298
	private string h;

	// Token: 0x0400300B RID: 12299
	private string i;

	// Token: 0x0400300C RID: 12300
	private new string j;

	// Token: 0x0400300D RID: 12301
	private new CharacterState? k;

	// Token: 0x0400300E RID: 12302
	private int? l;

	// Token: 0x0400300F RID: 12303
	private string m;

	// Token: 0x04003010 RID: 12304
	private new float? n;
}
