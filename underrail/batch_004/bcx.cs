using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020018EB RID: 6379
[eiz("VHC")]
[Serializable]
public sealed class bcx : ISerializable
{
	// Token: 0x06008718 RID: 34584 RVA: 0x0037E7C0 File Offset: 0x0037C9C0
	private bcx(SerializationInfo A_0, StreamingContext A_1)
	{
		this.b = (A_0.GetValue("VHC:DF", typeof(TypedObjectReference<amf>)) as TypedObjectReference<amf>);
		di7.ReadDictionary<string, agt>("VHC:P", ref this.c, A_0);
		this.d = (A_0.GetValue("VHC:T", typeof(dcw)) as dcw);
		this.e = (A_0.GetValue("VHC:D", typeof(efk)) as efk);
		this.g = (bws)A_0.GetValue("VHC:V", typeof(bws));
		this.h = A_0.GetDouble("VHC:S");
		this.k = A_0.GetInt32("VHC:MD");
		this.l = A_0.GetInt32("VHC:MB");
		di7.ReadDictionary<DamageType, du2>("VHC:R", ref this.m, A_0);
		this.n = (d8o)A_0.GetValue("VHC:A", typeof(d8o));
		this.o = A_0.GetDouble("VHC:C");
		this.p = A_0.GetDouble("VHC:ST");
		this.r = A_0.GetDouble("VHC:SM");
		this.s = A_0.GetDouble("VHC:VW");
		this.t = A_0.GetDouble("VHC:TW");
		this.u = A_0.GetInt32("VHC:EP");
		this.v = A_0.GetInt32("VHC:EC");
		di7.ReadList<drm>("VHC:SN", ref this.w, A_0);
		this.x = A_0.GetDouble("VHC:MS");
		this.y = A_0.GetDouble("VHC:ECT");
		this.z = A_0.GetDouble("VHC:DR");
		this.f = A_0.GetString("VHC:VM");
		if (ell.a() >= 378)
		{
			di7.ReadList<string>("VHC:PF", ref this.aa, A_0);
			this.ac = A_0.GetString("VHC:KC");
			this.ad = A_0.GetInt32("VHC:LS");
		}
		else
		{
			this.aa = new List<string>();
		}
		if (ell.a() >= 382)
		{
			this.ae = A_0.GetInt32("VHC:ILS");
			this.af = A_0.GetBoolean("VHC:IL");
		}
		else
		{
			this.ae = c3w.j;
		}
		if (ell.a() >= 386)
		{
			di7.ReadList<aia>("VHC:CP", ref this.ag, A_0);
		}
		else
		{
			this.ag = new List<aia>();
		}
		if (ell.a() >= 506)
		{
			this.i = A_0.GetDouble("VHC:E");
		}
		else
		{
			this.i = 1.0;
		}
		if (ell.a() >= 511)
		{
			this.q = A_0.GetDouble("VHC:M");
		}
		else
		{
			this.q = 0.5;
		}
		if (ell.a() >= 512)
		{
			this.j = A_0.GetDouble("VHC:MBD");
		}
		if (ell.a() >= 552)
		{
			this.ab = A_0.GetBoolean("VHC:AP");
			return;
		}
		this.ab = true;
	}

	// Token: 0x06008719 RID: 34585 RVA: 0x0037EB6C File Offset: 0x0037CD6C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("VHC:DF", this.b);
		di7.WriteDictionary<string, agt>("VHC:P", this.c, info);
		info.AddValue("VHC:T", this.d);
		info.AddValue("VHC:D", this.e);
		info.AddValue("VHC:V", this.g);
		info.AddValue("VHC:S", this.h);
		info.AddValue("VHC:MD", this.k);
		info.AddValue("VHC:MB", this.l);
		di7.WriteDictionary<DamageType, du2>("VHC:R", this.m, info);
		info.AddValue("VHC:A", this.n);
		info.AddValue("VHC:C", this.o);
		info.AddValue("VHC:ST", this.p);
		info.AddValue("VHC:SM", this.r);
		info.AddValue("VHC:VW", this.s);
		info.AddValue("VHC:TW", this.t);
		info.AddValue("VHC:EP", this.u);
		info.AddValue("VHC:EC", this.v);
		di7.WriteList<drm>("VHC:SN", this.w, info);
		info.AddValue("VHC:MS", this.x);
		info.AddValue("VHC:ECT", this.y);
		info.AddValue("VHC:DR", this.z);
		info.AddValue("VHC:VM", this.f);
		di7.WriteList<string>("VHC:PF", this.aa, info);
		info.AddValue("VHC:KC", this.ac);
		info.AddValue("VHC:LS", this.ad);
		info.AddValue("VHC:ILS", this.ae);
		info.AddValue("VHC:IL", this.af);
		di7.WriteList<aia>("VHC:CP", this.ag, info);
		info.AddValue("VHC:E", this.i);
		info.AddValue("VHC:M", this.q);
		info.AddValue("VHC:MBD", this.j);
		info.AddValue("VHC:AP", this.ab);
	}

	// Token: 0x0600871A RID: 34586 RVA: 0x0037EDA4 File Offset: 0x0037CFA4
	public dcw ap()
	{
		return this.d;
	}

	// Token: 0x0600871B RID: 34587 RVA: 0x0037EDAC File Offset: 0x0037CFAC
	public void a(dcw A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600871C RID: 34588 RVA: 0x0037EDB8 File Offset: 0x0037CFB8
	public double ag()
	{
		return this.z;
	}

	// Token: 0x0600871D RID: 34589 RVA: 0x0037EDC0 File Offset: 0x0037CFC0
	public void b(double A_0)
	{
		this.z = A_0;
	}

	// Token: 0x0600871E RID: 34590 RVA: 0x0037EDCC File Offset: 0x0037CFCC
	public TypedObjectReference<amf> ae()
	{
		return this.b;
	}

	// Token: 0x0600871F RID: 34591 RVA: 0x0037EDD4 File Offset: 0x0037CFD4
	public void a(TypedObjectReference<amf> A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06008720 RID: 34592 RVA: 0x0037EDE0 File Offset: 0x0037CFE0
	public Dictionary<string, agt> o()
	{
		return this.c;
	}

	// Token: 0x06008721 RID: 34593 RVA: 0x0037EDE8 File Offset: 0x0037CFE8
	public void a(Dictionary<string, agt> A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06008722 RID: 34594 RVA: 0x0037EDF4 File Offset: 0x0037CFF4
	public string f()
	{
		return this.ac;
	}

	// Token: 0x06008723 RID: 34595 RVA: 0x0037EDFC File Offset: 0x0037CFFC
	public void b(string A_0)
	{
		this.ac = A_0;
	}

	// Token: 0x06008724 RID: 34596 RVA: 0x0037EE08 File Offset: 0x0037D008
	public int z()
	{
		return this.ad;
	}

	// Token: 0x06008725 RID: 34597 RVA: 0x0037EE10 File Offset: 0x0037D010
	public void f(int A_0)
	{
		this.ad = A_0;
	}

	// Token: 0x06008726 RID: 34598 RVA: 0x0037EE1C File Offset: 0x0037D01C
	public int t()
	{
		return this.ae;
	}

	// Token: 0x06008727 RID: 34599 RVA: 0x0037EE24 File Offset: 0x0037D024
	public void c(int A_0)
	{
		this.ae = A_0;
	}

	// Token: 0x06008728 RID: 34600 RVA: 0x0037EE30 File Offset: 0x0037D030
	public bool af()
	{
		return this.af;
	}

	// Token: 0x06008729 RID: 34601 RVA: 0x0037EE38 File Offset: 0x0037D038
	public void a(bool A_0)
	{
		this.af = A_0;
	}

	// Token: 0x0600872A RID: 34602 RVA: 0x0037EE44 File Offset: 0x0037D044
	public List<string> l()
	{
		return this.aa;
	}

	// Token: 0x0600872B RID: 34603 RVA: 0x0037EE4C File Offset: 0x0037D04C
	public void a(List<string> A_0)
	{
		this.aa = A_0;
	}

	// Token: 0x0600872C RID: 34604 RVA: 0x0037EE58 File Offset: 0x0037D058
	public bool ak()
	{
		return this.ab;
	}

	// Token: 0x0600872D RID: 34605 RVA: 0x0037EE60 File Offset: 0x0037D060
	public void b(bool A_0)
	{
		this.ab = A_0;
	}

	// Token: 0x0600872E RID: 34606 RVA: 0x0037EE6C File Offset: 0x0037D06C
	public amf an()
	{
		if (this.b != null)
		{
			return this.b.ao();
		}
		return null;
	}

	// Token: 0x0600872F RID: 34607 RVA: 0x0037EE88 File Offset: 0x0037D088
	public bws y()
	{
		return this.g;
	}

	// Token: 0x06008730 RID: 34608 RVA: 0x0037EE90 File Offset: 0x0037D090
	public void a(bws A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06008731 RID: 34609 RVA: 0x0037EE9C File Offset: 0x0037D09C
	public double m()
	{
		return this.h;
	}

	// Token: 0x06008732 RID: 34610 RVA: 0x0037EEA4 File Offset: 0x0037D0A4
	public void l(double A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06008733 RID: 34611 RVA: 0x0037EEB0 File Offset: 0x0037D0B0
	public double u()
	{
		return this.i;
	}

	// Token: 0x06008734 RID: 34612 RVA: 0x0037EEB8 File Offset: 0x0037D0B8
	public void k(double A_0)
	{
		this.i = A_0;
	}

	// Token: 0x06008735 RID: 34613 RVA: 0x0037EEC4 File Offset: 0x0037D0C4
	public double q()
	{
		return this.j;
	}

	// Token: 0x06008736 RID: 34614 RVA: 0x0037EECC File Offset: 0x0037D0CC
	public void n(double A_0)
	{
		this.j = A_0;
	}

	// Token: 0x06008737 RID: 34615 RVA: 0x0037EED8 File Offset: 0x0037D0D8
	public efk p()
	{
		return this.e;
	}

	// Token: 0x06008738 RID: 34616 RVA: 0x0037EEE0 File Offset: 0x0037D0E0
	public void a(efk A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06008739 RID: 34617 RVA: 0x0037EEEC File Offset: 0x0037D0EC
	public double n()
	{
		return this.r;
	}

	// Token: 0x0600873A RID: 34618 RVA: 0x0037EEF4 File Offset: 0x0037D0F4
	public void f(double A_0)
	{
		this.r = A_0;
	}

	// Token: 0x0600873B RID: 34619 RVA: 0x0037EF00 File Offset: 0x0037D100
	public int v()
	{
		return this.k;
	}

	// Token: 0x0600873C RID: 34620 RVA: 0x0037EF08 File Offset: 0x0037D108
	public void h(int A_0)
	{
		this.k = A_0;
	}

	// Token: 0x0600873D RID: 34621 RVA: 0x0037EF14 File Offset: 0x0037D114
	public int am()
	{
		return this.l;
	}

	// Token: 0x0600873E RID: 34622 RVA: 0x0037EF1C File Offset: 0x0037D11C
	public void a(int A_0)
	{
		this.l = A_0;
	}

	// Token: 0x0600873F RID: 34623 RVA: 0x0037EF28 File Offset: 0x0037D128
	public double g()
	{
		return this.c();
	}

	// Token: 0x06008740 RID: 34624 RVA: 0x0037EF30 File Offset: 0x0037D130
	public Dictionary<DamageType, du2> j()
	{
		return this.m;
	}

	// Token: 0x06008741 RID: 34625 RVA: 0x0037EF38 File Offset: 0x0037D138
	public d8o s()
	{
		return this.n;
	}

	// Token: 0x06008742 RID: 34626 RVA: 0x0037EF40 File Offset: 0x0037D140
	public void a(d8o A_0)
	{
		this.n = A_0;
	}

	// Token: 0x06008743 RID: 34627 RVA: 0x0037EF4C File Offset: 0x0037D14C
	public double ad()
	{
		return this.o;
	}

	// Token: 0x06008744 RID: 34628 RVA: 0x0037EF54 File Offset: 0x0037D154
	public void e(double A_0)
	{
		this.o = A_0;
	}

	// Token: 0x06008745 RID: 34629 RVA: 0x0037EF60 File Offset: 0x0037D160
	public double aa()
	{
		return this.p;
	}

	// Token: 0x06008746 RID: 34630 RVA: 0x0037EF68 File Offset: 0x0037D168
	public void j(double A_0)
	{
		this.p = Math.Min(1.0, A_0);
	}

	// Token: 0x06008747 RID: 34631 RVA: 0x0037EF80 File Offset: 0x0037D180
	public double ao()
	{
		return this.q;
	}

	// Token: 0x06008748 RID: 34632 RVA: 0x0037EF88 File Offset: 0x0037D188
	public void g(double A_0)
	{
		this.q = Math.Min(1.0, A_0);
	}

	// Token: 0x06008749 RID: 34633 RVA: 0x0037EFA0 File Offset: 0x0037D1A0
	public double ac()
	{
		return this.s;
	}

	// Token: 0x0600874A RID: 34634 RVA: 0x0037EFA8 File Offset: 0x0037D1A8
	public void d(double A_0)
	{
		this.s = A_0;
	}

	// Token: 0x0600874B RID: 34635 RVA: 0x0037EFB4 File Offset: 0x0037D1B4
	public double w()
	{
		return this.t;
	}

	// Token: 0x0600874C RID: 34636 RVA: 0x0037EFBC File Offset: 0x0037D1BC
	public void i(double A_0)
	{
		this.t = A_0;
	}

	// Token: 0x0600874D RID: 34637 RVA: 0x0037EFC8 File Offset: 0x0037D1C8
	public int i()
	{
		return this.u;
	}

	// Token: 0x0600874E RID: 34638 RVA: 0x0037EFD0 File Offset: 0x0037D1D0
	public void g(int A_0)
	{
		this.u = A_0;
	}

	// Token: 0x0600874F RID: 34639 RVA: 0x0037EFDC File Offset: 0x0037D1DC
	public int ab()
	{
		return this.v;
	}

	// Token: 0x06008750 RID: 34640 RVA: 0x0037EFE4 File Offset: 0x0037D1E4
	public void d(int A_0)
	{
		this.v = A_0;
	}

	// Token: 0x06008751 RID: 34641 RVA: 0x0037EFF0 File Offset: 0x0037D1F0
	public List<drm> x()
	{
		return this.w;
	}

	// Token: 0x06008752 RID: 34642 RVA: 0x0037EFF8 File Offset: 0x0037D1F8
	public void a(List<drm> A_0)
	{
		this.w = A_0;
	}

	// Token: 0x06008753 RID: 34643 RVA: 0x0037F004 File Offset: 0x0037D204
	public double r()
	{
		return this.x;
	}

	// Token: 0x06008754 RID: 34644 RVA: 0x0037F00C File Offset: 0x0037D20C
	public void c(double A_0)
	{
		this.x = A_0;
	}

	// Token: 0x06008755 RID: 34645 RVA: 0x0037F018 File Offset: 0x0037D218
	public double h()
	{
		return this.y;
	}

	// Token: 0x06008756 RID: 34646 RVA: 0x0037F020 File Offset: 0x0037D220
	public void m(double A_0)
	{
		this.y = A_0;
	}

	// Token: 0x06008757 RID: 34647 RVA: 0x0037F02C File Offset: 0x0037D22C
	public string ah()
	{
		return this.f;
	}

	// Token: 0x06008758 RID: 34648 RVA: 0x0037F034 File Offset: 0x0037D234
	public void d(string A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06008759 RID: 34649 RVA: 0x0037F040 File Offset: 0x0037D240
	public List<aia> ai()
	{
		return this.ag;
	}

	// Token: 0x0600875A RID: 34650 RVA: 0x0037F048 File Offset: 0x0037D248
	public bool aj()
	{
		return this.t <= (double)this.u;
	}

	// Token: 0x0600875B RID: 34651 RVA: 0x0037F060 File Offset: 0x0037D260
	public bcx()
	{
		this.d();
	}

	// Token: 0x0600875C RID: 34652 RVA: 0x0037F0E0 File Offset: 0x0037D2E0
	public void k()
	{
		this.e();
		if (this.an() != null)
		{
			this.p = c3w.a[this.g];
			this.q = c3w.b[this.g];
			if (this.an().g() != null)
			{
				this.an().g().a(this);
			}
			foreach (KeyValuePair<string, agt> keyValuePair in this.c)
			{
				if (keyValuePair.Value != null)
				{
					if (!keyValuePair.Value.fu().j())
					{
						keyValuePair.Value.a(this);
					}
					this.s += keyValuePair.Value.Weight;
				}
			}
		}
		this.t += this.s;
		this.t += this.d.a();
		if (this.e != null)
		{
			this.t += this.e.bc;
		}
		if (this.z > (double)this.k)
		{
			this.z = (double)this.k;
		}
		this.b();
		this.a();
		if (this.e != null)
		{
			this.e.bl();
		}
	}

	// Token: 0x0600875D RID: 34653 RVA: 0x0037F268 File Offset: 0x0037D468
	public void a(du2 A_0)
	{
		du2 value = this.m[A_0.b()];
		value.a(A_0);
		if (A_0.b() == DamageType.Mechanical)
		{
			if (value.c() > as3.bv)
			{
				value.a(as3.bv);
			}
		}
		else if (value.c() > 1.0)
		{
			value.a(1.0);
		}
		this.m[A_0.b()] = value;
	}

	// Token: 0x0600875E RID: 34654 RVA: 0x0037F2F8 File Offset: 0x0037D4F8
	public void a(string A_0, string A_1, float A_2)
	{
		drm item = new drm(A_0, A_1, A_2);
		this.w.Add(item);
	}

	// Token: 0x0600875F RID: 34655 RVA: 0x0037F31C File Offset: 0x0037D51C
	public double a(double A_0)
	{
		double num = A_0;
		double num2 = A_0;
		if (A_0 > 0.0)
		{
			foreach (agt agt in this.c.Values)
			{
				if (agt != null && agt.fu() is esd)
				{
					double num3 = Math.Min(num, (double)agt.MaxBattery - agt.Battery);
					agt.Battery += num3;
					num -= num3;
					num2 += num3;
					if (num <= 0.0)
					{
						break;
					}
				}
			}
		}
		this.k();
		return num2;
	}

	// Token: 0x06008760 RID: 34656 RVA: 0x0037F3E8 File Offset: 0x0037D5E8
	public double h(double A_0)
	{
		double num = A_0;
		double num2 = A_0;
		if (A_0 > 0.0)
		{
			foreach (agt agt in this.c.Values)
			{
				if (agt != null && agt.fu() is esd)
				{
					double num3 = Math.Min(num, agt.Battery);
					agt.Battery -= num3;
					num -= num3;
					num2 += num3;
					if (num <= 0.0)
					{
						break;
					}
				}
			}
		}
		this.k();
		return num2;
	}

	// Token: 0x06008761 RID: 34657 RVA: 0x0037F4AC File Offset: 0x0037D6AC
	public double e(int A_0)
	{
		double num = Math.Min((double)A_0, (double)this.k - this.z);
		this.z += num;
		this.k();
		return num;
	}

	// Token: 0x06008762 RID: 34658 RVA: 0x0037F4E4 File Offset: 0x0037D6E4
	public void a(float A_0)
	{
		bool flag = this.g() == 0.0;
		double a_ = (double)A_0 * this.y;
		this.h(a_);
		if (!flag && this.g() == 0.0)
		{
			this.k();
		}
	}

	// Token: 0x06008763 RID: 34659 RVA: 0x0037F534 File Offset: 0x0037D734
	public void b(int A_0)
	{
		this.z = (double)Math.Max(0, (int)(this.z - (double)A_0));
	}

	// Token: 0x06008764 RID: 34660 RVA: 0x0037F550 File Offset: 0x0037D750
	public bool al()
	{
		if (this.an() != null)
		{
			foreach (c38 c in this.an().e())
			{
				agt agt;
				this.c.TryGetValue(c.h(), out agt);
				if (agt == null && !c.g())
				{
					return false;
				}
				if (agt != null && agt.fu().j())
				{
					return false;
				}
			}
			return true;
		}
		return false;
	}

	// Token: 0x06008765 RID: 34661 RVA: 0x0037F600 File Offset: 0x0037D800
	public bool b(efk A_0)
	{
		return this.af || string.IsNullOrWhiteSpace(this.ac) || Enumerable.Any<coh>(A_0.Bag.b(this.ac));
	}

	// Token: 0x06008766 RID: 34662 RVA: 0x0037F640 File Offset: 0x0037D840
	private void e()
	{
		this.d();
		this.f = null;
		this.s = 0.0;
		this.t = 0.0;
		this.n = d8o.a;
		this.o = 0.0;
		this.k = 0;
		this.l = 0;
		this.h = 0.0;
		this.r = 0.0;
		this.p = 0.0;
		this.q = 0.0;
		this.u = 0;
		this.v = 0;
		this.x = 0.0;
		this.y = 0.0;
		this.ag.Clear();
		this.w.Clear();
	}

	// Token: 0x06008767 RID: 34663 RVA: 0x0037F71C File Offset: 0x0037D91C
	private void d()
	{
		foreach (object obj in Enum.GetValues(typeof(DamageType)))
		{
			DamageType damageType = (DamageType)obj;
			this.m[damageType] = new du2(damageType, 0, 0.0);
		}
	}

	// Token: 0x06008768 RID: 34664 RVA: 0x0037F79C File Offset: 0x0037D99C
	private double c()
	{
		double num = 0.0;
		foreach (KeyValuePair<string, agt> keyValuePair in this.c)
		{
			if (keyValuePair.Value != null && keyValuePair.Value.fu() is esd)
			{
				num += keyValuePair.Value.Battery;
			}
		}
		return num;
	}

	// Token: 0x06008769 RID: 34665 RVA: 0x0037F82C File Offset: 0x0037DA2C
	private void b()
	{
		double num = c3w.c[this.g];
		this.h = num;
		if (this.t != (double)this.u)
		{
			int num2 = (int)((double)this.u - this.t);
			double num3;
			if (num2 > 0)
			{
				num3 = (double)num2 * (c3w.c[this.g] / 500.0);
			}
			else if (num2 < 0)
			{
				num3 = (double)num2 * (c3w.c[this.g] / 200.0);
			}
			else
			{
				num3 = 0.0;
			}
			this.h = Math.Max(0.1, this.h + num3);
		}
		if (this.g() == 0.0)
		{
			this.h = this.m() * c3w.g;
		}
		this.h = Math.Round(Math.Min(this.h, num * c3w.e), 1);
		this.h = Math.Round(Math.Max(this.h, num * c3w.f), 1);
		if ((this.g() > 0.0 && this.t <= (double)this.u) || this.r < 1.0)
		{
			this.h *= this.r;
			if (this.e != null && this.e.StatusEffects.a(ckc.a))
			{
				this.h *= 1.0 + cd8.c;
			}
		}
		double num4 = c3w.c[this.g] * 1.2;
		if (this.h > num4)
		{
			this.i = 1.0 + (this.h - num4) / 5.0;
		}
		else
		{
			this.i = this.h / num4;
		}
		this.i *= this.q;
		double num5 = c3w.c[this.g] * 1.1;
		if (this.h > num5)
		{
			this.j = (this.h - num5) / 9.0;
			return;
		}
		this.j = 0.0;
	}

	// Token: 0x0600876A RID: 34666 RVA: 0x0037FAA0 File Offset: 0x0037DCA0
	private void a()
	{
		if (this.e != null && this.e.StatusEffects.a(ckc.a))
		{
			this.v = Convert.ToInt32((1.0 + cd8.f) * (double)this.v);
		}
		this.y = Math.Round((double)this.v / (double)c3w.d[this.g], 2);
	}

	// Token: 0x0600876B RID: 34667 RVA: 0x0037FB1C File Offset: 0x0037DD1C
	public void c(string A_0)
	{
		eoq.SerializeToBinaryFileCompressed<bcx>(A_0, this, dds.a(), eh9.c, true);
	}

	// Token: 0x0600876C RID: 34668 RVA: 0x0037FB30 File Offset: 0x0037DD30
	public static bcx a(string A_0)
	{
		return eoq.DeserializeFromBinaryFileCompressed<bcx>(A_0, dds.a(), true);
	}

	// Token: 0x0400349F RID: 13471
	public static readonly string a = "v";

	// Token: 0x040034A0 RID: 13472
	private TypedObjectReference<amf> b;

	// Token: 0x040034A1 RID: 13473
	private Dictionary<string, agt> c = new Dictionary<string, agt>();

	// Token: 0x040034A2 RID: 13474
	private dcw d = new dcw(true);

	// Token: 0x040034A3 RID: 13475
	private efk e;

	// Token: 0x040034A4 RID: 13476
	private string f;

	// Token: 0x040034A5 RID: 13477
	private bws g;

	// Token: 0x040034A6 RID: 13478
	private double h;

	// Token: 0x040034A7 RID: 13479
	private double i;

	// Token: 0x040034A8 RID: 13480
	private double j;

	// Token: 0x040034A9 RID: 13481
	private int k;

	// Token: 0x040034AA RID: 13482
	private int l;

	// Token: 0x040034AB RID: 13483
	private Dictionary<DamageType, du2> m = new Dictionary<DamageType, du2>();

	// Token: 0x040034AC RID: 13484
	private d8o n;

	// Token: 0x040034AD RID: 13485
	private double o;

	// Token: 0x040034AE RID: 13486
	private double p;

	// Token: 0x040034AF RID: 13487
	private double q;

	// Token: 0x040034B0 RID: 13488
	private double r = 1.0;

	// Token: 0x040034B1 RID: 13489
	private double s;

	// Token: 0x040034B2 RID: 13490
	private double t;

	// Token: 0x040034B3 RID: 13491
	private int u;

	// Token: 0x040034B4 RID: 13492
	private int v;

	// Token: 0x040034B5 RID: 13493
	private List<drm> w = new List<drm>();

	// Token: 0x040034B6 RID: 13494
	private double x;

	// Token: 0x040034B7 RID: 13495
	private double y;

	// Token: 0x040034B8 RID: 13496
	private double z;

	// Token: 0x040034B9 RID: 13497
	private List<string> aa = new List<string>();

	// Token: 0x040034BA RID: 13498
	private bool ab = true;

	// Token: 0x040034BB RID: 13499
	private string ac;

	// Token: 0x040034BC RID: 13500
	private int ad;

	// Token: 0x040034BD RID: 13501
	private int ae = c3w.j;

	// Token: 0x040034BE RID: 13502
	private bool af;

	// Token: 0x040034BF RID: 13503
	private List<aia> ag = new List<aia>();
}
