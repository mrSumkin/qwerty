using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using Microsoft.Xna.Framework;
using Ouroboros.Common;
using Ouroboros.Common.Aspects;
using Ouroboros.Common.Data;
using Ouroboros.Events;
using Ouroboros.Playfield.Lightning;
using Ouroboros.Playfield.References;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Comm;
using TimelapseVertigo.Rules.Items;
using TimelapseVertigo.Rules.Locale;

// Token: 0x0200131C RID: 4892
[eiz("CEA")]
[Serializable]
public sealed class amc : Aspect<c5x>, aig, c02, ISerializable, bp1, p0, cmm, chb, b0w, b4t, d4o
{
	// Token: 0x06006E45 RID: 28229 RVA: 0x002E1200 File Offset: 0x002DF400
	private amc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.j = A_0.GetString("CEA:M");
			this.k = A_0.GetBoolean("CEA:P");
			this.l = A_0.GetBoolean("CEA:VIF");
			this.m = (IProvider<efk>)A_0.GetValue("CEA:C", typeof(IProvider<efk>));
			this.n = (cbg)A_0.GetValue("CEA:SS", typeof(cbg));
			this.o = A_0.GetString("CEA:LM");
			this.p = A_0.GetBoolean("CEA:ASR");
			this.u = A_0.GetBoolean("CEA:SM");
			di7.ReadList<cze>("CEA:CIAJ", ref this.w, A_0);
			di7.ReadList<cze>("CEA:CDJ", ref this.x, A_0);
			this.ac = A_0.GetDouble("CEA:ST");
			this.ag = (int?)A_0.GetValue("CEA:CXA", typeof(int?));
			this.ah = A_0.GetSingle("CEA:XM");
			if (ell.a() >= 11)
			{
				this.ai = (A_0.GetValue("CEA:SND", typeof(t)) as t);
			}
			else
			{
				this.ai = new t();
			}
			if (ell.a() >= 25)
			{
				this.aj = (ai5)A_0.GetValue("CEA:CMC", typeof(ai5));
			}
			else
			{
				this.aj = ai5.a;
			}
			if (ell.a() >= 59)
			{
				this.al = A_0.GetSingle("CEA:H");
				this.am = A_0.GetSingle("CEA:G");
			}
			else
			{
				this.al = 1f;
				this.am = 1f;
			}
			if (ell.a() >= 84)
			{
				this.ap = (A_0.GetValue("CEA:C1", typeof(CharacterState?)) as CharacterState?);
				this.aq = (A_0.GetValue("CEA:C2", typeof(int?)) as int?);
			}
			if (ell.a() >= 85)
			{
				this.r = A_0.GetBoolean("CEA:LC");
			}
			if (ell.a() >= 186)
			{
				this.@as = (A_0.GetValue("CEA:C3", typeof(CharacterState?)) as CharacterState?);
				this.at = (A_0.GetValue("CEA:C4", typeof(int?)) as int?);
			}
			if (ell.a() >= 201)
			{
				this.au = A_0.GetString("CEA:SL");
			}
			if (ell.a() >= 282)
			{
				this.ad = A_0.GetDouble("CEA:PST");
			}
			if (ell.a() >= 310)
			{
				this.q = A_0.GetBoolean("CEA:ADER");
			}
			if (ell.a() >= 315)
			{
				this.v = A_0.GetBoolean("CEA:PU");
			}
			if (ell.a() >= 383)
			{
				this.aw = (A_0.GetValue("CEA:VC", typeof(c1i)) as c1i);
			}
			if (ell.a() >= 384)
			{
				this.ax = A_0.GetBoolean("CEA:VCD");
			}
			if (ell.a() >= 401)
			{
				this.ay = (A_0.GetValue("CEA:IVC", typeof(ae4)) as ae4);
			}
			else
			{
				this.ay = new ae4();
			}
			if (ell.a() >= 409)
			{
				di7.ReadList<cze>("CEA:PSJ", ref this.y, A_0);
			}
			else
			{
				this.y = new List<cze>();
			}
			if (ell.a() >= 434)
			{
				this.a2 = A_0.GetString("CEA:MEC");
				this.a3 = A_0.GetString("CEA:MECD");
			}
			if (ell.a() >= 456)
			{
				di7.ReadList<cze>("CEA:HBJ", ref this.z, A_0);
			}
			else
			{
				this.z = new List<cze>();
			}
			if (ell.a() >= 498)
			{
				di7.ReadList<cze>("CEA:CDF", ref this.aa, A_0);
			}
			else
			{
				this.aa = new List<cze>();
			}
			if (ell.a() >= 522)
			{
				di7.ReadList<cze>("CEA:CMJ", ref this.ab, A_0);
			}
			else
			{
				this.ab = new List<cze>();
			}
			if (ell.a() >= 523)
			{
				this.ar = (A_0.GetValue("CEA:P2", typeof(int?)) as int?);
			}
			if (ell.a() >= 564)
			{
				this.t = A_0.GetBoolean("CEA:SD");
			}
			if (ell.a() >= 604)
			{
				this.an = (A_0.GetValue("CEA:EM", typeof(float?)) as float?);
				this.ao = (A_0.GetValue("CEA:CT", typeof(Color?)) as Color?);
			}
			if (ell.a() >= 635)
			{
				this.s = A_0.GetBoolean("CEA:NS");
				return;
			}
		}
		else
		{
			this.k = A_0.GetBoolean("_Player");
			this.p = A_0.GetBoolean("_AlwaysSpawnRemains");
			this.l = A_0.GetBoolean("_VisibleInFog");
			this.ac = A_0.GetDouble("_SearchTimer");
			this.ag = (A_0.GetValue("_CustomXpAmount", typeof(int?)) as int?);
			this.ah = A_0.GetSingle("_XpModifier");
			this.j = A_0.GetString("_Model");
			this.m = (A_0.GetValue("_Character", typeof(IProvider<efk>)) as IProvider<efk>);
			this.n = (A_0.GetValue("_SpecialStates", typeof(cbg)) as cbg);
			this.o = A_0.GetString("_LootbagModel");
			this.u = A_0.GetBoolean("_SuppressMaterializer");
			di7.ReadList<cze>("_CharacterIsAttackedJobs", ref this.w, A_0);
			di7.ReadList<cze>("_CharacterDiedJobs", ref this.x, A_0);
		}
	}

	// Token: 0x06006E46 RID: 28230 RVA: 0x002E1914 File Offset: 0x002DFB14
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CEA:M", this.j);
		info.AddValue("CEA:P", this.k);
		info.AddValue("CEA:VIF", this.l);
		info.AddValue("CEA:C", this.m);
		info.AddValue("CEA:SS", this.n);
		info.AddValue("CEA:LM", this.o);
		info.AddValue("CEA:ASR", this.p);
		info.AddValue("CEA:SM", this.u);
		di7.WriteList<cze>("CEA:CIAJ", this.w, info);
		di7.WriteList<cze>("CEA:CDJ", this.x, info);
		info.AddValue("CEA:ST", this.ac);
		info.AddValue("CEA:CXA", this.ag);
		info.AddValue("CEA:XM", this.ah);
		info.AddValue("CEA:SND", this.ai);
		info.AddValue("CEA:CMC", this.aj);
		info.AddValue("CEA:H", this.al);
		info.AddValue("CEA:G", this.am);
		info.AddValue("CEA:C1", this.ap);
		info.AddValue("CEA:C2", this.aq);
		info.AddValue("CEA:P2", this.ar);
		info.AddValue("CEA:C3", this.@as);
		info.AddValue("CEA:C4", this.at);
		info.AddValue("CEA:LC", this.r);
		info.AddValue("CEA:SL", this.au);
		info.AddValue("CEA:PST", this.ad);
		info.AddValue("CEA:ADER", this.q);
		info.AddValue("CEA:PU", this.v);
		info.AddValue("CEA:VC", this.aw);
		info.AddValue("CEA:VCD", this.ax);
		info.AddValue("CEA:IVC", this.ay);
		di7.WriteList<cze>("CEA:PSJ", this.y, info);
		info.AddValue("CEA:MEC", this.a2);
		info.AddValue("CEA:MECD", this.a3);
		di7.WriteList<cze>("CEA:HBJ", this.z, info);
		di7.WriteList<cze>("CEA:CDF", this.aa, info);
		di7.WriteList<cze>("CEA:CMJ", this.ab, info);
		info.AddValue("CEA:SD", this.t);
		info.AddValue("CEA:EM", this.an);
		info.AddValue("CEA:CT", this.ao);
		info.AddValue("CEA:NS", this.s);
	}

	// Token: 0x06006E47 RID: 28231 RVA: 0x002E1C00 File Offset: 0x002DFE00
	public int? ap()
	{
		return this.ag;
	}

	// Token: 0x06006E48 RID: 28232 RVA: 0x002E1C08 File Offset: 0x002DFE08
	public void a(int? A_0)
	{
		this.ag = A_0;
	}

	// Token: 0x06006E49 RID: 28233 RVA: 0x002E1C14 File Offset: 0x002DFE14
	public float ak()
	{
		return this.ah;
	}

	// Token: 0x06006E4A RID: 28234 RVA: 0x002E1C1C File Offset: 0x002DFE1C
	public void d(float A_0)
	{
		this.ah = A_0;
	}

	// Token: 0x06006E4B RID: 28235 RVA: 0x002E1C28 File Offset: 0x002DFE28
	public CharacterState af()
	{
		if (base.a8().i.b != null && base.a8().i.b.a() != null && base.a8().i.b.a().q1() != null)
		{
			return base.a8().i.b.a().q1().Value;
		}
		if (this.aa().Dead)
		{
			return CharacterState.Die;
		}
		if (this.ap != null)
		{
			return this.ap.Value;
		}
		if (this.aa().SpecialStates.a || this.aa().SpecialStates.c)
		{
			return CharacterState.Stunned;
		}
		return CharacterState.Idle;
	}

	// Token: 0x06006E4C RID: 28236 RVA: 0x002E1D0C File Offset: 0x002DFF0C
	public int x()
	{
		if (base.a8().i.b != null && base.a8().i.b.a() != null && base.a8().i.b.a().q1() != null && base.a8().i.b.a().tm() != null)
		{
			am5 am;
			int num;
			if (this.e.TryGetValue(this.af(), out am))
			{
				num = Math.Max(1, am.a);
			}
			else
			{
				num = 1;
			}
			return base.a8().i.b.a().tm().Value % num;
		}
		if (this.aa().Dead)
		{
			return this.g.a[CharacterState.Die].a - 1;
		}
		if (this.aa().SpecialStates.h || this.aa().SpecialStates.k)
		{
			return 0;
		}
		if (this.aq != null)
		{
			return this.aq.Value;
		}
		return this.a6;
	}

	// Token: 0x06006E4D RID: 28237 RVA: 0x002E1E60 File Offset: 0x002E0060
	public int aw()
	{
		if (this.a7 == null)
		{
			this.a7 = new int?(cuo.a.Next(1000));
		}
		return this.a7.Value;
	}

	// Token: 0x06006E4E RID: 28238 RVA: 0x002E1E98 File Offset: 0x002E0098
	public string am()
	{
		return this.j;
	}

	// Token: 0x06006E4F RID: 28239 RVA: 0x002E1EA0 File Offset: 0x002E00A0
	public void a(string A_0)
	{
		if (this.j != A_0)
		{
			this.j = A_0;
			if (base.a8() != null && base.a8().Initialized)
			{
				this.s();
			}
		}
	}

	// Token: 0x06006E50 RID: 28240 RVA: 0x002E1EDC File Offset: 0x002E00DC
	public float h9()
	{
		cnk service = bpo.GetService<cnk>();
		if (service != null && service.aqy() != null && service.aqy().alk() && service.aqy().all())
		{
			return this.m.ao().BaseMovementSpeed * aju.d;
		}
		float num;
		if (this.m.ao() != null)
		{
			num = this.m.ao().MovementSpeed * aju.d;
		}
		else
		{
			num = 0f;
		}
		if (!dz6.e())
		{
			return num;
		}
		if (base.a8().c(dm9.b))
		{
			return dz6.a(num);
		}
		return dz6.d();
	}

	// Token: 0x06006E51 RID: 28241 RVA: 0x002E1F98 File Offset: 0x002E0198
	public float ia()
	{
		return this.h9();
	}

	// Token: 0x06006E52 RID: 28242 RVA: 0x002E1FA0 File Offset: 0x002E01A0
	public efk aa()
	{
		return this.m.ao();
	}

	// Token: 0x06006E53 RID: 28243 RVA: 0x002E1FB0 File Offset: 0x002E01B0
	public string v()
	{
		return this.o;
	}

	// Token: 0x06006E54 RID: 28244 RVA: 0x002E1FB8 File Offset: 0x002E01B8
	public void b(string A_0)
	{
		this.o = A_0;
	}

	// Token: 0x06006E55 RID: 28245 RVA: 0x002E1FC4 File Offset: 0x002E01C4
	public bool ar()
	{
		return this.p;
	}

	// Token: 0x06006E56 RID: 28246 RVA: 0x002E1FCC File Offset: 0x002E01CC
	public void i(bool A_0)
	{
		this.p = A_0;
	}

	// Token: 0x06006E57 RID: 28247 RVA: 0x002E1FD8 File Offset: 0x002E01D8
	public bool ab()
	{
		return this.q;
	}

	// Token: 0x06006E58 RID: 28248 RVA: 0x002E1FE0 File Offset: 0x002E01E0
	public void c(bool A_0)
	{
		this.q = A_0;
	}

	// Token: 0x06006E59 RID: 28249 RVA: 0x002E1FEC File Offset: 0x002E01EC
	public bool a1()
	{
		return this.s;
	}

	// Token: 0x06006E5A RID: 28250 RVA: 0x002E1FF4 File Offset: 0x002E01F4
	public void f(bool A_0)
	{
		this.s = A_0;
	}

	// Token: 0x06006E5B RID: 28251 RVA: 0x002E2000 File Offset: 0x002E0200
	public bool ax()
	{
		return this.r;
	}

	// Token: 0x06006E5C RID: 28252 RVA: 0x002E2008 File Offset: 0x002E0208
	public void g(bool A_0)
	{
		this.r = A_0;
	}

	// Token: 0x06006E5D RID: 28253 RVA: 0x002E2014 File Offset: 0x002E0214
	public amr qv()
	{
		if (this.m.ao() != null)
		{
			return this.m.ao().Defense;
		}
		return null;
	}

	// Token: 0x06006E5E RID: 28254 RVA: 0x002E2038 File Offset: 0x002E0238
	public bool a7()
	{
		return this.u;
	}

	// Token: 0x06006E5F RID: 28255 RVA: 0x002E2040 File Offset: 0x002E0240
	public void d(bool A_0)
	{
		this.u = A_0;
	}

	// Token: 0x06006E60 RID: 28256 RVA: 0x002E204C File Offset: 0x002E024C
	public bool ac()
	{
		return this.v;
	}

	// Token: 0x06006E61 RID: 28257 RVA: 0x002E2054 File Offset: 0x002E0254
	public void a(bool A_0)
	{
		this.v = A_0;
	}

	// Token: 0x06006E62 RID: 28258 RVA: 0x002E2060 File Offset: 0x002E0260
	public List<cze> a6()
	{
		return this.w;
	}

	// Token: 0x06006E63 RID: 28259 RVA: 0x002E2068 File Offset: 0x002E0268
	public void c(List<cze> A_0)
	{
		this.w = A_0;
	}

	// Token: 0x06006E64 RID: 28260 RVA: 0x002E2074 File Offset: 0x002E0274
	public List<cze> ay()
	{
		return this.x;
	}

	// Token: 0x06006E65 RID: 28261 RVA: 0x002E207C File Offset: 0x002E027C
	public void d(List<cze> A_0)
	{
		this.x = A_0;
	}

	// Token: 0x06006E66 RID: 28262 RVA: 0x002E2088 File Offset: 0x002E0288
	public List<cze> av()
	{
		return this.y;
	}

	// Token: 0x06006E67 RID: 28263 RVA: 0x002E2090 File Offset: 0x002E0290
	public void a(List<cze> A_0)
	{
		this.y = A_0;
	}

	// Token: 0x06006E68 RID: 28264 RVA: 0x002E209C File Offset: 0x002E029C
	public List<cze> au()
	{
		return this.z;
	}

	// Token: 0x06006E69 RID: 28265 RVA: 0x002E20A4 File Offset: 0x002E02A4
	public void b(List<cze> A_0)
	{
		this.z = A_0;
	}

	// Token: 0x06006E6A RID: 28266 RVA: 0x002E20B0 File Offset: 0x002E02B0
	public List<cze> aj()
	{
		return this.aa;
	}

	// Token: 0x06006E6B RID: 28267 RVA: 0x002E20B8 File Offset: 0x002E02B8
	public void e(List<cze> A_0)
	{
		this.aa = A_0;
	}

	// Token: 0x06006E6C RID: 28268 RVA: 0x002E20C4 File Offset: 0x002E02C4
	public List<cze> aq()
	{
		return this.ab;
	}

	// Token: 0x06006E6D RID: 28269 RVA: 0x002E20CC File Offset: 0x002E02CC
	public void f(List<cze> A_0)
	{
		this.ab = A_0;
	}

	// Token: 0x06006E6E RID: 28270 RVA: 0x002E20D8 File Offset: 0x002E02D8
	public bool @as()
	{
		return this.k;
	}

	// Token: 0x06006E6F RID: 28271 RVA: 0x002E20E0 File Offset: 0x002E02E0
	public void h(bool A_0)
	{
		this.k = A_0;
	}

	// Token: 0x06006E70 RID: 28272 RVA: 0x002E20EC File Offset: 0x002E02EC
	public bool ae()
	{
		return this.l;
	}

	// Token: 0x06006E71 RID: 28273 RVA: 0x002E20F4 File Offset: 0x002E02F4
	public void e(bool A_0)
	{
		this.l = A_0;
	}

	// Token: 0x06006E72 RID: 28274 RVA: 0x002E2100 File Offset: 0x002E0300
	public t ag()
	{
		return this.ai;
	}

	// Token: 0x06006E73 RID: 28275 RVA: 0x002E2108 File Offset: 0x002E0308
	public void a(t A_0)
	{
		this.ai = A_0;
	}

	// Token: 0x06006E74 RID: 28276 RVA: 0x002E2114 File Offset: 0x002E0314
	public ai5 an()
	{
		return this.aj;
	}

	// Token: 0x06006E75 RID: 28277 RVA: 0x002E211C File Offset: 0x002E031C
	public void a(ai5 A_0)
	{
		this.aj = A_0;
	}

	// Token: 0x06006E76 RID: 28278 RVA: 0x002E2128 File Offset: 0x002E0328
	public string a0()
	{
		return this.au;
	}

	// Token: 0x06006E77 RID: 28279 RVA: 0x002E2130 File Offset: 0x002E0330
	public void c(string A_0)
	{
		this.au = A_0;
	}

	// Token: 0x06006E78 RID: 28280 RVA: 0x002E213C File Offset: 0x002E033C
	public Guid ao()
	{
		return this.av;
	}

	// Token: 0x06006E79 RID: 28281 RVA: 0x002E2144 File Offset: 0x002E0344
	public c1i z()
	{
		return this.aw;
	}

	// Token: 0x06006E7A RID: 28282 RVA: 0x002E214C File Offset: 0x002E034C
	public void a(c1i A_0)
	{
		this.aw = A_0;
	}

	// Token: 0x06006E7B RID: 28283 RVA: 0x002E2158 File Offset: 0x002E0358
	public bool ah()
	{
		return this.ax;
	}

	// Token: 0x06006E7C RID: 28284 RVA: 0x002E2160 File Offset: 0x002E0360
	public string az()
	{
		return this.a2;
	}

	// Token: 0x06006E7D RID: 28285 RVA: 0x002E2168 File Offset: 0x002E0368
	public void d(string A_0)
	{
		this.a2 = A_0;
	}

	// Token: 0x06006E7E RID: 28286 RVA: 0x002E2174 File Offset: 0x002E0374
	public amc(c5x A_0) : this(A_0, new StandAloneProvider<efk>(new efk()))
	{
	}

	// Token: 0x06006E7F RID: 28287 RVA: 0x002E218C File Offset: 0x002E038C
	public amc(c5x A_0, IProvider<efk> A_1) : base(A_0)
	{
		czh.a(A_1, "character");
		this.m = A_1;
		if (this.m.ao() != null && this.m.ao().Defense.i4())
		{
			this.p();
		}
		this.ae = new amc.f(this);
		this.af = new amc.c(this);
	}

	// Token: 0x06006E80 RID: 28288 RVA: 0x002E2280 File Offset: 0x002E0480
	public void r7(eds A_0)
	{
		if (this.aa() != null && this.aa().Vehicle != null)
		{
			this.aa().Defense.a(false);
		}
		if (this.aa() is e3q)
		{
			this.b();
		}
		this.a5();
		double totalMilliseconds = A_0.b.TotalMilliseconds;
		if (this.m.ao() != null)
		{
			this.m.ao().a(this, totalMilliseconds, A_0.c);
		}
		if (!A_0.c)
		{
			if ((this.ac -= totalMilliseconds) <= 0.0)
			{
				this.d();
			}
			if ((this.ad -= totalMilliseconds) <= 0.0)
			{
				this.a(int.MaxValue);
				this.ad += (double)d0u.b;
				lh lh = ckw.a(base.a8());
				if (lh != null)
				{
					lh.mh(this);
				}
			}
		}
		string text = null;
		if (base.a8().i.b != null)
		{
			b6p b6p = base.a8().i.b.a() as b6p;
			if (b6p != null)
			{
				text = b6p.oj();
			}
		}
		if (text != this.h)
		{
			this.h = text;
			this.s();
		}
		cnk service = bpo.GetService<cnk>();
		bool? flag;
		if (service == null)
		{
			flag = null;
		}
		else
		{
			ls ls = service.aq1();
			flag = ((ls != null) ? new bool?(ls.g().g) : null);
		}
		bool? flag2 = flag;
		bool valueOrDefault = flag2.GetValueOrDefault(true);
		if (this.i != valueOrDefault)
		{
			this.i = valueOrDefault;
			this.s();
		}
		this.a(2);
		this.b(A_0);
		this.d(totalMilliseconds);
		this.c(totalMilliseconds);
		this.a(A_0);
		this.b(totalMilliseconds);
	}

	// Token: 0x06006E81 RID: 28289 RVA: 0x002E2488 File Offset: 0x002E0688
	public void b(eds A_0)
	{
		TimeSpan timeSpan;
		if (A_0 == null)
		{
			cnk service = bpo.GetService<cnk>();
			if (service == null || service.aqw() == null)
			{
				return;
			}
			timeSpan = service.aqw().ElapsedZoneTime;
		}
		else
		{
			timeSpan = A_0.a;
		}
		int num;
		if (this.ar != null)
		{
			num = this.ar.Value;
			if (num <= 0)
			{
				num = 1073741823;
			}
		}
		else
		{
			num = cux.b;
		}
		int num2 = this.e[this.af()].a;
		if (num2 <= 0)
		{
			num2 = 1;
		}
		this.a6 = ((int)(timeSpan.TotalMilliseconds / (double)num) + this.aw()) % num2;
	}

	// Token: 0x06006E82 RID: 28290 RVA: 0x002E253C File Offset: 0x002E073C
	public void ai()
	{
		if (this.m.ao() != null)
		{
			this.m.ao().b(this);
			this.d();
			this.a(int.MaxValue);
			lh lh = ckw.a(base.a8());
			if (lh != null)
			{
				lh.mh(this);
			}
		}
	}

	// Token: 0x06006E83 RID: 28291 RVA: 0x002E2594 File Offset: 0x002E0794
	public void mx()
	{
		base.a8().b(e2b.a);
		base.a8().e = true;
		if (this.k)
		{
			base.a8().g |= e2b.d;
		}
		this.a5();
		this.n();
		this.al();
		this.w();
		if (this.m.ao() != null)
		{
			this.m.ao().bl();
		}
		this.s();
		if (base.a8().j.b != null && base.a8().j.b.f() == null)
		{
			base.a8().j.b.a(this);
		}
		cnk service = bpo.GetService<cnk>();
		if (this.aw != null)
		{
			if (!this.ax && service != null && service.aqu() != null)
			{
				this.t();
			}
		}
		else
		{
			this.ax = false;
		}
		if (base.a8() != null && base.a8().t.b != null)
		{
			d02 service2 = bpo.GetService<d02>();
			if (service2 != null)
			{
				service2.ahx(this);
			}
		}
		if (this.m.ao() != null)
		{
			foreach (els els in this.m.ao().StatusEffects.d())
			{
				cf9 cf = a4p.a(els);
				if (cf != null)
				{
					cf.rx(els, this);
				}
				else if (els.w != null)
				{
					cze cze = dv0.a(els.w);
					if (cze != null)
					{
						a4s a_ = new a4s(cze, null, new ar7(base.a8()), null);
						base.a8().Zone.ActionManager.g9(a_, atp.a);
					}
				}
			}
		}
	}

	// Token: 0x06006E84 RID: 28292 RVA: 0x002E279C File Offset: 0x002E099C
	public void my()
	{
		if (this.m.ao() != null)
		{
			foreach (els els in this.m.ao().StatusEffects.d())
			{
				cf9 cf = a4p.a(els);
				if (cf != null)
				{
					cf.ry(els, this);
				}
				else if (els.x != null)
				{
					cze cze = dv0.a(els.x);
					if (cze != null)
					{
						cze.ym(null, base.a8(), null);
					}
				}
			}
		}
		base.a8().g &= ~e2b.a;
		base.a8().g &= ~e2b.d;
		this.al();
		d02 service = bpo.GetService<d02>();
		if (service != null)
		{
			service.ahy(this);
		}
	}

	// Token: 0x06006E85 RID: 28293 RVA: 0x002E2898 File Offset: 0x002E0A98
	public bool hj(b0b A_0, Vector3 A_1, Vector3 A_2, float A_3)
	{
		aig aig = base.a8().i.b.a() as aig;
		if (aig != null)
		{
			aig.hj(A_0, A_1, A_2, A_3);
		}
		this.a(2);
		if (this.aa().Vehicle != null && this.aa() is e3q)
		{
			bool flag = this.aa().Vehicle.g() == 0.0;
			this.aa().Vehicle.a(A_3);
			if (!flag && this.aa().Vehicle.g() == 0.0)
			{
				this.aa().bl();
				d02 service = bpo.GetService<d02>();
				if (service != null && service.ahg())
				{
					d4n d4n = service.ahu(this.aa());
					if (d4n != null && service.ahe() == d4n)
					{
						if (base.a8().i.b != null)
						{
							base.a8().i.b.a(m7.e, true, false);
						}
						d4n.d = 0.0;
					}
				}
				bmj.a(base.a8(), new d53("Батарея разряжена!", Color.Red, null, false));
				this.at();
			}
		}
		this.ay.a(this, A_3, null, null);
		ar7 classPropertyValue = base.a8().d().a().GetClassPropertyValue<ar7>(bah.c);
		if (classPropertyValue != null && classPropertyValue.ao() != null && classPropertyValue.ao().GetAspect<bdf>() != null)
		{
			bcx a_ = null;
			wv wv = classPropertyValue.ao().GetAspect<bim>() as wv;
			if (wv != null)
			{
				a_ = wv.g();
			}
			this.ay.a(this, A_3, classPropertyValue.ao() as c5x, a_);
		}
		this.c(A_3);
		this.b(A_3);
		this.a(A_3);
		Dictionary<string, object> dictionary = a3f.a(base.a8());
		dictionary["oldLocation"] = A_1;
		dictionary["newLocation"] = A_2;
		dictionary["distance"] = A_3;
		foreach (cze cze in this.ab)
		{
			cze.ym(base.a8(), base.a8(), dictionary);
		}
		foreach (els els in Enumerable.ToList<els>(this.aa().StatusEffects.d()))
		{
			if (els.ac != null)
			{
				this.a(els.ac, els, dictionary);
			}
		}
		return false;
	}

	// Token: 0x06006E86 RID: 28294 RVA: 0x002E2B98 File Offset: 0x002E0D98
	public void a(av A_0, object A_1)
	{
		czh.a(A_0, "proxy");
		eu7 eu = A_0 as eu7;
		if (eu != null)
		{
			cp.b(eu, base.a8(), A_1);
			return;
		}
		bl6 bl = A_0 as bl6;
		if (bl != null)
		{
			cp.a(bl, base.a8(), false);
		}
	}

	// Token: 0x06006E87 RID: 28295 RVA: 0x002E2BE8 File Offset: 0x002E0DE8
	public btk b(amc A_0)
	{
		czh.a(A_0, "target");
		btk btk = new btk(this, A_0);
		d02 service = bpo.GetService<d02>();
		atp a_;
		if ((service != null && service.ahg()) || base.a8().IsPlayer)
		{
			a_ = atp.a;
		}
		else
		{
			a_ = atp.c;
		}
		base.a8().i.b.a(btk, a_, true, false);
		return btk;
	}

	// Token: 0x06006E88 RID: 28296 RVA: 0x002E2C54 File Offset: 0x002E0E54
	public void a(cwt A_0, bool A_1)
	{
		this.aa().Dead = true;
		d0f d0f = Enumerable.FirstOrDefault<d0f>(this.aa().StatusEffects.Get<d0f>());
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		f8 a_ = new f8(new ap9(this.aa()), A_1);
		bey.a(a_, this.aa(), this);
		b7u b7u = b7u.a;
		if (d0f != null)
		{
			b7u = b7u.c;
		}
		if (this.aa().Vehicle != null && this.aa().Vehicle.ag() == 0.0)
		{
			b7u = b7u.d;
		}
		else if (A_1)
		{
			bmj.a(base.a8(), new cz5("Разбит!", new Color(0, 128, 255), null, true));
			b7u = b7u.b;
		}
		else if (b7u != b7u.c && Enumerable.FirstOrDefault<bk9>(this.aa().StatusEffects.Get<bk9>()) != null)
		{
			b7u = b7u.e;
		}
		if (!this.t)
		{
			a7v.a(a_);
		}
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary["killingBlow"] = A_0;
		dictionary["deathType"] = b7u;
		dictionary["attackResult"] = A_0;
		foreach (els els in Enumerable.ToList<els>(this.aa().StatusEffects.d()))
		{
			if (els.ag != null)
			{
				this.a(els.ag, els, dictionary);
			}
		}
		d3q a_2 = new d3q(this, b7u);
		if (base.a8().i.b != null)
		{
			base.a8().i.b.a(m7.b, true, false);
			base.a8().i.b.a(a_2, atp.a, true, false);
		}
		if (A_0 != null && A_0.i != null)
		{
			if (A_0.i.b == asp.a || A_0.i.j)
			{
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().e() == ExperienceSystem.Classic)
				{
					int num;
					if (this.ap() != null)
					{
						num = this.ap().Value;
					}
					else
					{
						num = c2h.e(this.aa());
					}
					int a_3 = Convert.ToInt32((float)num * this.ak());
					int num2 = Math.Min(aiy.bf, c2h.b(serviceOrThrow.aqu().v()));
					int num3 = c2h.a(a_3, (double)this.aa().Level, (double)num2);
					if (num3 > 0)
					{
						c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
						if (c5x != null && c5x.h.b != null)
						{
							c5x.h.b.a(num3, null);
						}
					}
				}
				if (!(this.aa() is e3q))
				{
					if (!this.aa().Passive && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().Feats.Contains<bt7>() && A_0.ad.GetPrimitivePropertyValue<bool>("IsBurst", new bool?(false)).Value && !euf.a(A_0.ae) && !euf.b(A_0.ae))
					{
						ip ip = serviceOrThrow.aqu().v().Cooldowns.b(bt7.a);
						if (ip == null || ip.a <= 0.0)
						{
							int num4 = serviceOrThrow.aqu().v().GetSpecializationValue<lr>(true) * lr.a;
							if (num4 > 0)
							{
								d02 service = bpo.GetService<d02>();
								if (service != null)
								{
									d4n d4n = service.ahu(serviceOrThrow.aqu().v());
									if (d4n != null && d4n == service.ahe())
									{
										int num5 = num4;
										if (num5 > 0)
										{
											d4n.c += (double)num5;
											if (serviceOrThrow.aqu().v().b() != null)
											{
												bmj.a(serviceOrThrow.aqu().v().b(), new d53(string.Format("+{0} ед. действия{1}", num5, (num5 > 1) ? "" : ""), adi.ap, "Коммандо", false));
												vr a_4 = new vr(new ap9(serviceOrThrow.aqu().v()), null, string.Concat(new string[]
												{
													"{0} восстановлено ",
													num5.ToString(),
													" ед. действия",
													(num5 > 1) ? "" : "",
													" будучи полным коммандо."
												}), new Color?(adi.ap), null);
												bey.a(a_4, serviceOrThrow.aqu().v(), serviceOrThrow.aqu().v().b().GetAspect<amc>());
												a7v.a(a_4);
											}
										}
									}
								}
							}
							serviceOrThrow.aqu().v().StatusEffects.a(new di(), false, false, false);
							serviceOrThrow.aqu().v().Cooldowns.a(new cfd[]
							{
								new cfd(bt7.a, d0u.b, false, true)
							});
						}
					}
					if (!this.aa().Passive)
					{
						if (A_1)
						{
							cxc.c(eyy.aw);
						}
						if (!this.aa().Passive && !this.aa().c(d8o.e))
						{
							cxc.c(eyy.a);
						}
						if (this.aa().c(d8o.i))
						{
							cxc.a(eyy.a4);
						}
						if (this.aa().c(d8o.e))
						{
							cxc.a(eyy.a5);
						}
						if (this.aa().c(d8o.b))
						{
							cxc.a(eyy.a6);
						}
						if (euf.d(A_0.x) || A_0.ae.GetValueOrDefault() == WeaponSubtype.Unarmed || A_0.ae.GetValueOrDefault() == WeaponSubtype.Glove_Leather || A_0.ae.GetValueOrDefault() == WeaponSubtype.Glove_Metal)
						{
							cxc.a(eyy.a7);
						}
						if (A_0.x == AmmoType.Knife || A_0.x == AmmoType.Dagger || A_0.ae.GetValueOrDefault() == WeaponSubtype.Knife || A_0.ae.GetValueOrDefault() == WeaponSubtype.Dagger || A_0.ae.GetValueOrDefault() == WeaponSubtype.SerratedKnife)
						{
							cxc.a(eyy.a8);
						}
						if (A_0.x == AmmoType.Sword || A_0.x == AmmoType.ObsidianSword || A_0.ae.GetValueOrDefault() == WeaponSubtype.Sword)
						{
							cxc.a(eyy.a9);
						}
						if (A_0.x == AmmoType.Spear || A_0.ae.GetValueOrDefault() == WeaponSubtype.Spear)
						{
							cxc.a(eyy.ba);
						}
						if (A_0.x == AmmoType.Sledgehammer || A_0.ae.GetValueOrDefault() == WeaponSubtype.Sledgehammer)
						{
							cxc.a(eyy.bb);
						}
						if (eub.f(A_0.x) || (A_0.ae != null && euf.g(A_0.ae.Value)))
						{
							cxc.a(eyy.bc);
						}
						if (A_0.x == AmmoType.Energy || A_0.ae.GetValueOrDefault() == WeaponSubtype.Pistol_Laser || A_0.ae.GetValueOrDefault() == WeaponSubtype.Pistol_Plasma || A_0.ae.GetValueOrDefault() == WeaponSubtype.FusionCannon || A_0.ad.GetPrimitivePropertyValue<bool>("IsEnergyWeapon", new bool?(false)).Value)
						{
							cxc.a(eyy.bd);
						}
						if ((A_0.x >= AmmoType.Vial_Acid && A_0.x < (AmmoType)2000) || A_0.ad.GetPrimitivePropertyValue<bool>("IsAcidWeapon", new bool?(false)).Value)
						{
							cxc.a(eyy.be);
						}
						if ((!string.IsNullOrEmpty(A_0.k) && A_0.k.IndexOf("grenade", StringComparison.OrdinalIgnoreCase) != -1) || A_0.ad.GetPrimitivePropertyValue<bool>("IsGrenade", new bool?(false)).Value)
						{
							cxc.a(eyy.bf);
						}
						if (A_0.ad.GetPrimitivePropertyValue<bool>("IsTrap", new bool?(false)).Value)
						{
							cxc.a(eyy.bl);
						}
						if (A_0.x == AmmoType.Bolts || A_0.ae.GetValueOrDefault() == WeaponSubtype.Crossbow)
						{
							cxc.a(eyy.bg);
						}
						PsiSchool? primitivePropertyValue = A_0.ad.GetPrimitivePropertyValue<PsiSchool>("PsionicSource", null);
						PsiSchool psiSchool = PsiSchool.Metathermics;
						if (primitivePropertyValue.GetValueOrDefault() == psiSchool & primitivePropertyValue != null)
						{
							cxc.a(eyy.bh);
						}
						if (A_0.ad.GetPrimitivePropertyValue<PsiSchool>("PsionicSource", null).GetValueOrDefault() == PsiSchool.ThoughtControl)
						{
							cxc.a(eyy.bi);
						}
						if (A_0.ad.GetPrimitivePropertyValue<PsiSchool>("PsionicSource", null).GetValueOrDefault() == PsiSchool.Psychokinesis)
						{
							cxc.a(eyy.bj);
						}
						if (A_0.ad.GetPrimitivePropertyValue<PsiSchool>("PsionicSource", null).GetValueOrDefault() == PsiSchool.TemporalManipulation)
						{
							cxc.a(eyy.bk);
						}
						if ((A_0.a & c3u.f) != c3u.a)
						{
							cxc.c(eyy.ap);
						}
						if (this.aa().FactionId == asp.d && base.a8().t.b != null)
						{
							Guid? primitivePropertyValue2 = base.a8().t.b.y6().GetPrimitivePropertyValue<Guid>(ddq.a3, null);
							if (primitivePropertyValue2 != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null && serviceOrThrow.aqu().v().b().qe() == primitivePropertyValue2.Value)
							{
								cxc.c(eyy.ax);
							}
						}
					}
				}
			}
			if (this.aa() is e3q && A_0.i.b != asp.a && (A_0.i.g & d8o.e) != d8o.a && A_0.i.d != Guid.Empty)
			{
				int num6 = cxc.a.GetPrimitivePropertyValue<int>("Killed_By_Count_" + A_0.i.d.ToString(), new int?(0)).Value;
				num6++;
				if (num6 >= 3)
				{
					cxc.c(eyy.@as);
				}
				cxc.a["Killed_By_Count_" + A_0.i.d.ToString()] = num6;
			}
			if (A_0.af != Guid.Empty && !this.aa().Passive)
			{
				int num7 = cxc.a.GetPrimitivePropertyValue<int>("Kill_Count_For_Attack_" + A_0.af.ToString(), new int?(0)).Value;
				num7++;
				cxc.a["Kill_Count_For_Attack_" + A_0.af.ToString()] = num7;
				cxc.a["Attack_Is_Grenade_" + A_0.af.ToString()] = A_0.ad.GetPrimitivePropertyValue<bool>("IsGrenade", new bool?(false)).Value;
				cxc.a["Faction_Of_Attack_" + A_0.af.ToString()] = A_0.i.b;
				if (A_0.i.b == asp.a && !(this.aa() is e3q))
				{
					if (num7 >= 5 && A_0.ad.GetPrimitivePropertyValue<bool>("IsGrenade", new bool?(false)).Value && cxc.a.GetPrimitivePropertyValue<Guid>("Attack_That_Killed_Player", new Guid?(Guid.Empty)).Value != A_0.af)
					{
						cxc.c(eyy.az);
					}
					if (num7 >= 3 && A_0.k == "Burst")
					{
						cxc.c(eyy.a0);
					}
				}
			}
			if (this.aa() is e3q)
			{
				cxc.a["Attack_That_Killed_Player"] = A_0.af;
			}
		}
		Dictionary<string, object> dictionary2 = a3f.a(base.a8());
		if (d0f != null)
		{
			dm5 dm = new dm5();
			dm.a(asp.a);
			dm.d("Термодинамическая детонация");
			dm.a(0.2);
			dm.s().AddRange(aph.a(d0f.Damage));
			dm.b(100);
			dm.c("ScorchGround");
			dm.d(true);
			dm.b("HeGrenadeExplode");
			dm.i()["PsionicSource"] = PsiSchool.Metathermics;
			dm.f().Add(new amc.d(d0f.c));
			dm.c(true);
			dm.ym(null, base.a8(), dictionary2);
			ak1 ak = base.a8().Area.a(base.a8().aj().a());
			boj.c(base.a8().Area, ak.Location);
			if (boj.b(base.a8().Area, ak.Location))
			{
				boj.a(base.a8().Area, ak.Location);
				aud a_5 = base.a8().Area;
				Vector3 a_6 = ak.Location.a() + new Vector3(0.4f, 0.4f, 0f);
				HorizontalDirection? a_7 = null;
				string a_8 = "BlurredSmokeSlow" + (cuo.a.Next(3) + 1).ToString();
				int a_9 = 1;
				double maxValue = double.MaxValue;
				float? a_10 = new float?(0.66f);
				boj.a(a_5, a_6, a_7, a_8, a_9, maxValue, null, a_10, null, null);
			}
		}
		if (bp5.a(this.aa().Id))
		{
			serviceOrThrow.aqu().r()[bp5.b(this.aa().Id)] = true;
		}
		if (this.x != null)
		{
			foreach (cze cze in this.x)
			{
				dictionary2["killingBlow"] = A_0;
				dictionary2["deathType"] = b7u;
				cze.ym(null, base.a8(), dictionary2);
			}
		}
		a3f aspect = base.a8().GetAspect<a3f>();
		if (aspect != null && aspect.a().GetPrimitivePropertyValue<bool>("TrackKiller", new bool?(false)).Value && serviceOrThrow.aqu() != null && A_0 != null && A_0.i != null && !string.IsNullOrEmpty(A_0.i.b))
		{
			serviceOrThrow.aqu().r()[string.Format("{0}_killedbyfaction", this.aa().Id)] = A_0.i.b;
		}
		lh lh = ckw.a(base.a8());
		if (lh != null)
		{
			lh.q6(this);
		}
		this.aa().CustomProperties.RemoveProperty(ddm.i);
		this.a2();
	}

	// Token: 0x06006E89 RID: 28297 RVA: 0x002E3D68 File Offset: 0x002E1F68
	public void a(int A_0, string A_1 = null)
	{
		if (A_0 != 0)
		{
			e3q e3q = this.aa() as e3q;
			if (e3q != null)
			{
				bool flag = c2h.a(e3q);
				A_0 = e3q.c(A_0);
				bool flag2 = !flag && c2h.a(e3q);
				a7v.a(new ey2(new ap9(e3q), A_0, flag2, A_1));
				if (flag2 && base.a8() != null)
				{
					boj.a(base.a8(), "LevelUp", 1, double.MaxValue, false, true, null, null, null, null, false);
					base.a8().c().a("LevelUp", "LevelUp", 1f, c9z.a, false, false);
					bmj.a(base.a8(), new d53("Новый уровень!", adi.c, null, true));
				}
			}
		}
	}

	// Token: 0x06006E8A RID: 28298 RVA: 0x002E3E58 File Offset: 0x002E2058
	public void u()
	{
		if (this.m.ao().SpecialStates.g)
		{
			aty a_ = new aty(ecf.a(dgk.Get<e5b>(), new eru(new EntityAspectReference<amc, amc>(this)), null) as bl6, base.a8(), new bool?(false));
			base.a8().i.b.b(a_, atp.a);
		}
	}

	// Token: 0x06006E8B RID: 28299 RVA: 0x002E3EC4 File Offset: 0x002E20C4
	public ai5 b(bool A_0 = false)
	{
		List<a2> list = this.aa().StatusEffects.Get<a2>();
		if (list != null && list.Count > 0)
		{
			return ai5.e;
		}
		if (this.aa().Vehicle != null)
		{
			return ai5.g;
		}
		return this.ak;
	}

	// Token: 0x06006E8C RID: 28300 RVA: 0x002E3F10 File Offset: 0x002E2110
	public void ad()
	{
		this.aa().Cooldowns.a();
		this.aa().Offense.aq();
	}

	// Token: 0x06006E8D RID: 28301 RVA: 0x002E3F40 File Offset: 0x002E2140
	public h a(amc A_0)
	{
		if (A_0 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				return this.aa().a(serviceOrThrow.aqu().ac(), A_0.aa().FactionId);
			}
		}
		return global::h.c;
	}

	// Token: 0x06006E8E RID: 28302 RVA: 0x002E3F88 File Offset: 0x002E2188
	public List<ak1> y()
	{
		List<ak1> list = new List<ak1>();
		if ((base.a8().g & e2b.d) != (e2b)0)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().a() != null)
			{
				long a_ = serviceOrThrow.aqu().v().a().d;
				int num = (int)Math.Min(this.aa().SightRange, 5f);
				int num2 = (int)(base.a8().Location.X - (float)num - 1f);
				while ((float)num2 < base.a8().Location.X + (float)num + 1f)
				{
					int num3 = (int)(base.a8().Location.Y - (float)num - 1f);
					while ((float)num3 < base.a8().Location.Y + (float)num + 1f)
					{
						ak1 ak = base.a8().Area.b(num2, num3);
						if (ak != null && aw1.a(base.a8(), ak) <= (double)num && ak.Formation.c(5136L) && ak.b(a_))
						{
							list.Add(ak);
						}
						num3++;
					}
					num2++;
				}
			}
		}
		else if (!this.aa().Passive && base.a8().t.b != null)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null && service.ahg())
			{
				using (HashSet<r0>.Enumerator enumerator = base.a8().t.b.b(service).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						r0 r = enumerator.Current;
						ak1 ak2 = base.a8().Area.b((int)r.a.X, (int)r.a.Y);
						if (ak2 != null && ak2.Formation.c(5120L))
						{
							list.Add(ak2);
						}
					}
					return list;
				}
			}
			List<Point> list2 = base.a8().t.b.z();
			if (list2 != null)
			{
				foreach (Point point in list2)
				{
					if (bnx.a(point, base.a8()) <= this.aa().SightRange)
					{
						ak1 ak3 = base.a8().Area.b(point.X, point.Y);
						if (ak3 != null && ak3.Formation.c(5120L))
						{
							list.Add(ak3);
						}
					}
				}
			}
		}
		return list;
	}

	// Token: 0x06006E8F RID: 28303 RVA: 0x002E42AC File Offset: 0x002E24AC
	public void w()
	{
		if (this.m.ao() != null)
		{
			this.aa().StatusEffects.j(new EventHandler<dwu>(this.b));
			this.aa().StatusEffects.f(new EventHandler<dwu>(this.c));
			this.aa().StatusEffects.c(new EventHandler<dwu>(this.d));
			this.aa().StatusEffects.a(new EventHandler<dwu>(this.a));
			this.aa().a(new EventHandler<b8x>(this.a));
			this.aa().Offense.b(new EventHandler<EventArgs>(this.b));
			this.aa().Offense.d(new EventHandler<ax0>(this.b));
			this.aa().Offense.c(new EventHandler<ax0>(this.a));
			this.aa().Defense.b(new EventHandler<dj7>(this.g));
			this.aa().Defense.b(new EventHandler<dsj>(this.a));
			this.aa().Defense.j(new EventHandler<dj7>(this.f));
			this.aa().Defense.d(new EventHandler<dj7>(this.e));
			this.aa().Defense.g(new EventHandler<dj7>(this.d));
			this.aa().Defense.l(new EventHandler<dj7>(this.c));
			this.aa().Defense.b(new EventHandler<b8x>(this.b));
			this.aa().Defense.b(new EventHandler<zl>(this.a));
			this.aa().Defense.n(new EventHandler<dj7>(this.b));
			this.aa().Defense.e(new EventHandler<dj7>(this.a));
			this.aa().a(new EventHandler<EventArgs>(this.a));
			this.aa().Gear.d(new EventHandler<by0>(this.c));
			this.aa().Gear.b(new EventHandler<by0>(this.d));
			this.aa().Bag.zw(new EventHandler<by0>(this.b));
			this.aa().Bag.zy(new EventHandler<by0>(this.a));
		}
		if (this.ae == null)
		{
			this.ae = new amc.f(this);
		}
		if (this.af == null)
		{
			this.af = new amc.c(this);
		}
		eta service = bpo.GetService<eta>();
		if (service != null)
		{
			service.RegisterHandler<eoa>(this.ae);
			service.RegisterHandler<ext>(this.af);
		}
	}

	// Token: 0x06006E90 RID: 28304 RVA: 0x002E4598 File Offset: 0x002E2798
	public void al()
	{
		if (this.aa() != null)
		{
			this.aa().StatusEffects.d(new EventHandler<dwu>(this.b));
			this.aa().StatusEffects.h(new EventHandler<dwu>(this.c));
			this.aa().StatusEffects.e(new EventHandler<dwu>(this.d));
			this.aa().StatusEffects.i(new EventHandler<dwu>(this.a));
			this.aa().b(new EventHandler<b8x>(this.a));
			this.aa().Offense.a(new EventHandler<EventArgs>(this.b));
			this.aa().Offense.a(new EventHandler<ax0>(this.b));
			this.aa().Offense.b(new EventHandler<ax0>(this.a));
			this.aa().Defense.c(new EventHandler<dj7>(this.g));
			this.aa().Defense.a(new EventHandler<dsj>(this.a));
			this.aa().Defense.i(new EventHandler<dj7>(this.f));
			this.aa().Defense.k(new EventHandler<dj7>(this.e));
			this.aa().Defense.f(new EventHandler<dj7>(this.d));
			this.aa().Defense.m(new EventHandler<dj7>(this.c));
			this.aa().Defense.a(new EventHandler<b8x>(this.b));
			this.aa().Defense.a(new EventHandler<zl>(this.a));
			this.aa().Defense.h(new EventHandler<dj7>(this.b));
			this.aa().Defense.a(new EventHandler<dj7>(this.a));
			this.aa().c(new EventHandler<EventArgs>(this.a));
			this.aa().Gear.c(new EventHandler<by0>(this.c));
			this.aa().Gear.a(new EventHandler<by0>(this.d));
			this.aa().Bag.zx(new EventHandler<by0>(this.b));
			this.aa().Bag.zz(new EventHandler<by0>(this.a));
		}
		eta service = bpo.GetService<eta>();
		if (service != null)
		{
			if (this.ae != null)
			{
				service.UnregisterHandler<eoa>(this.ae);
			}
			if (this.af != null)
			{
				service.UnregisterHandler<ext>(this.af);
			}
		}
	}

	// Token: 0x06006E91 RID: 28305 RVA: 0x002E4864 File Offset: 0x002E2A64
	public void c9(TimeSpan A_0)
	{
		if (this.aa() != null && this.aa().Suspicion > 0.0)
		{
			this.aa().Suspicion = Math.Max(0.0, this.aa().Suspicion - A_0.TotalMinutes * 0.02);
		}
	}

	// Token: 0x06006E92 RID: 28306 RVA: 0x002E48CC File Offset: 0x002E2ACC
	public void da(TimeSpan A_0)
	{
	}

	// Token: 0x06006E93 RID: 28307 RVA: 0x002E48D4 File Offset: 0x002E2AD4
	public void at()
	{
		string classPropertyValue = this.aa().CustomProperties.GetClassPropertyValue<string>(ddm.a);
		bool value = this.aa().CustomProperties.GetPrimitivePropertyValue<bool>(ddm.b, new bool?(false)).Value;
		if (!string.IsNullOrEmpty(classPropertyValue) || value)
		{
			return;
		}
		if (this.aa() != null && this.aa().Vehicle != null)
		{
			this.aa().Defense.a(false);
			if (this.aa() is e3q)
			{
				this.a(((this.aa().Gender == Gender.Male) ? "v_" : "v_f_") + this.aa().Vehicle.ah());
			}
			base.a8().Size = new Vector3(1f, 1f, 1.4f);
			base.a8().y = true;
			aru aru = base.a8().c();
			foreach (KeyValuePair<string, app> keyValuePair in Enumerable.ToList<KeyValuePair<string, app>>(aru.e()))
			{
				if (keyValuePair.Key.StartsWith("vehicle_", StringComparison.OrdinalIgnoreCase))
				{
					aru.a(keyValuePair.Key, false);
				}
			}
			foreach (drm drm in this.aa().Vehicle.x())
			{
				string text = string.Format("vehicle_{0}", drm.a);
				if (base.a8() != null && base.a8().Zone != null)
				{
					aru.a(text, drm.b, 0f, c9z.a, true, false);
				}
				else
				{
					Dictionary<string, app> dictionary = aru.e();
					string key = text;
					app app = new app();
					app.a(drm.b);
					app.a(0f);
					app.b(true);
					app.a(c9z.a);
					dictionary.Add(key, app);
				}
			}
			bsf bsf = null;
			foreach (ejt ejt in base.a8().RaysEmitters)
			{
				bsf bsf2 = ejt as bsf;
				if (bsf2 != null && bsf2.Definition != null && bsf2.Definition.Name == "vehicleLight")
				{
					bsf = bsf2;
					break;
				}
			}
			if (this.aa().Vehicle.an().f())
			{
				ah7 ah;
				if (bsf == null)
				{
					ah = new ah7("vehicleLight", base.a8().Zone);
				}
				else
				{
					ah = bsf.Definition;
				}
				if (this.aa().Vehicle.g() == 0.0)
				{
					ah.Light = new ae8(this.aa().Vehicle.an().b(), 0.375f, LightType.Increment);
					ah.LightFadeRate = 0.1f;
					ah.Range = 4f;
				}
				else
				{
					ah.Light = new ae8(this.aa().Vehicle.an().b(), 0.75f, LightType.Increment);
					ah.LightFadeRate = 0.2f;
					ah.Range = 4f;
				}
				if (bsf == null)
				{
					bsf = ah.g();
					bsf.be(base.a8());
				}
				else
				{
					ah.d();
				}
			}
			else if (bsf != null)
			{
				bsf.ig();
			}
		}
		else
		{
			if (this.aa() is e3q)
			{
				this.a((this.aa().Gender == Gender.Male) ? bln.a : bln.b);
			}
			base.a8().Size = new Vector3(1f, 1f, 1.65f);
			base.a8().y = false;
			aru aru2 = base.a8().c();
			foreach (KeyValuePair<string, app> keyValuePair2 in Enumerable.ToList<KeyValuePair<string, app>>(aru2.e()))
			{
				if (keyValuePair2.Key.StartsWith("vehicle_", StringComparison.OrdinalIgnoreCase))
				{
					aru2.a(keyValuePair2.Key, false);
				}
			}
			foreach (ejt ejt2 in base.a8().RaysEmitters)
			{
				bsf bsf3 = ejt2 as bsf;
				if (bsf3 != null && bsf3.Definition != null && bsf3.Definition.Name == "vehicleLight")
				{
					bsf3.ig();
					break;
				}
			}
		}
		this.aa().bl();
	}

	// Token: 0x06006E94 RID: 28308 RVA: 0x002E4E3C File Offset: 0x002E303C
	public void a(b0b A_0)
	{
		if (this.y != null)
		{
			foreach (cze cze in this.y)
			{
				cze.ym(A_0, base.a8(), null);
			}
		}
	}

	// Token: 0x06006E95 RID: 28309 RVA: 0x002E4EA8 File Offset: 0x002E30A8
	public void a(bcx A_0)
	{
		this.aa().Vehicle = A_0;
		this.aa().Vehicle.a(this.aa());
		this.aa().Defense.a(false);
		this.aa().bl();
		this.at();
	}

	// Token: 0x06006E96 RID: 28310 RVA: 0x002E4EFC File Offset: 0x002E30FC
	public zx e(string A_0)
	{
		string a_ = null;
		string text = null;
		string a_2 = null;
		this.ak = this.aj;
		if (this.aa().Gear.l().Item != null && this.aa().Gear.l().Item.fu() != null && !string.IsNullOrEmpty(this.aa().Gear.l().Item.fu().e()))
		{
			a_2 = this.aa().Gear.l().Item.fu().e();
			if (this.aa().Gear.l().Item.fu().d() != null)
			{
				this.ak = this.aa().Gear.l().Item.fu().d().Value;
			}
		}
		if (A_0 != null)
		{
			a_ = A_0;
		}
		else if (this.aa().Offense.u() != null && this.aa().Offense.u().TypedDefinition != null)
		{
			if (!string.IsNullOrEmpty(this.aa().Offense.u().TypedDefinition.ac()))
			{
				if (this.aa() is e3q)
				{
					a_ = bz9.d(this.aa().Offense.u().TypedDefinition.ac());
				}
				else
				{
					a_ = this.aa().Offense.u().TypedDefinition.ac();
				}
			}
			if (this.aa() is e3q && !string.IsNullOrEmpty(this.aa().Offense.u().TypedDefinition.m()) && this.aa().Vehicle == null)
			{
				ItemSlot<c8d> itemSlot = this.aa().Gear.l();
				bool? flag;
				if (itemSlot == null)
				{
					flag = null;
				}
				else
				{
					c8d c8d = itemSlot.Item;
					if (c8d == null)
					{
						flag = null;
					}
					else
					{
						c43 c = c8d.fu();
						flag = ((c != null) ? new bool?(c.f) : null);
					}
				}
				bool? flag2 = flag;
				if (flag2.GetValueOrDefault(true))
				{
					text = this.aa().Offense.u().TypedDefinition.m();
					ItemSlot<c8d> itemSlot2 = this.aa().Gear.l();
					bool? flag3;
					if (itemSlot2 == null)
					{
						flag3 = null;
					}
					else
					{
						c8d c8d2 = itemSlot2.Item;
						flag3 = ((c8d2 != null) ? new bool?(c8d2.fu().a()) : null);
					}
					flag2 = flag3;
					if (flag2.GetValueOrDefault() && euf.d(this.aa().Offense.u().TypedDefinition).GetValueOrDefault() == WeaponSubtype.Spear)
					{
						text += "1h";
					}
				}
			}
		}
		return bz9.a(this.j, a_2, a_, this.aa().Gender, text);
	}

	// Token: 0x06006E97 RID: 28311 RVA: 0x002E522C File Offset: 0x002E342C
	public void c()
	{
		if (base.a8() != null && base.a8().t.b == null)
		{
			this.ai();
		}
	}

	// Token: 0x06006E98 RID: 28312 RVA: 0x002E5254 File Offset: 0x002E3454
	public void a2()
	{
		this.a(0.0);
	}

	// Token: 0x06006E99 RID: 28313 RVA: 0x002E5268 File Offset: 0x002E3468
	public void a5()
	{
		if (!string.IsNullOrWhiteSpace(this.aa().Portrait))
		{
			this.aa().bd = this.aa().Portrait;
			return;
		}
		this.aa().bd = this.am();
	}

	// Token: 0x06006E9A RID: 28314 RVA: 0x002E52B4 File Offset: 0x002E34B4
	public void a3()
	{
		HashSet<string> hashSet = new HashSet<string>();
		foreach (coh coh in this.aa().Gear.i())
		{
			diz diz = coh.Definition as diz;
			if (diz != null && diz.ap() != null)
			{
				amc.b b = new amc.b();
				b.a = "gearLantern_" + coh.Id.ToString();
				ae8 ae = new ae8(diz.ap().Value, diz.au(), diz.aq() ? LightType.Decrement : LightType.Increment);
				bsf bsf = Enumerable.FirstOrDefault<bsf>(Enumerable.Where<bsf>(Enumerable.OfType<bsf>(base.a8().RaysEmitters), new Func<bsf, bool>(b.a)));
				if (bsf == null)
				{
					bsf = new ah7(b.a, null)
					{
						Light = ae,
						LightFadeRate = diz.aw(),
						Range = diz.ax()
					}.g();
					bsf.be(base.a8());
				}
				else
				{
					ah7 ah = bsf.Definition;
					if (ah != null)
					{
						bool flag = false;
						if (ae8.a(ah.Light, ae))
						{
							ah.Light = ae;
							flag = true;
						}
						if (ah.LightFadeRate != diz.aw())
						{
							ah.LightFadeRate = diz.aw();
							flag = true;
						}
						if (ah.Range != diz.ax())
						{
							ah.Range = diz.ax();
							flag = true;
						}
						if (flag)
						{
							ah.d();
						}
					}
				}
				hashSet.Add(b.a);
			}
		}
		foreach (ejt ejt in Enumerable.ToList<ejt>(base.a8().RaysEmitters))
		{
			bsf bsf2 = ejt as bsf;
			if (bsf2 != null && bsf2.Definition != null && bsf2.Definition.Name != null && bsf2.Definition.Name.StartsWith("gearLantern", StringComparison.OrdinalIgnoreCase) && !hashSet.Contains(bsf2.Definition.Name))
			{
				bsf2.ig();
			}
		}
	}

	// Token: 0x06006E9B RID: 28315 RVA: 0x002E556C File Offset: 0x002E376C
	public void a4()
	{
		foreach (ejt ejt in Enumerable.ToList<ejt>(base.a8().RaysEmitters))
		{
			bsf bsf = ejt as bsf;
			if (bsf != null && bsf.Definition != null && bsf.Definition.Name != null && bsf.Definition.Name.StartsWith("gearLantern", StringComparison.OrdinalIgnoreCase))
			{
				bsf.ig();
			}
		}
	}

	// Token: 0x06006E9C RID: 28316 RVA: 0x002E5610 File Offset: 0x002E3810
	private void t()
	{
		bcx bcx = null;
		if (this.aw != null)
		{
			bcx = this.aw.qy();
		}
		if (bcx != null)
		{
			this.ax = true;
			this.a(bcx);
		}
	}

	// Token: 0x06006E9D RID: 28317 RVA: 0x002E564C File Offset: 0x002E384C
	private void s()
	{
		this.g = this.e(this.h);
		this.e = this.g.a;
		this.f = this.g.b;
	}

	// Token: 0x06006E9E RID: 28318 RVA: 0x002E5684 File Offset: 0x002E3884
	private bool r()
	{
		return base.a8().j == cgy.b;
	}

	// Token: 0x06006E9F RID: 28319 RVA: 0x002E5694 File Offset: 0x002E3894
	private void a(string A_0, els A_1, ll A_2)
	{
		if (!string.IsNullOrEmpty(A_0))
		{
			g5 g = dpo.b(A_0);
			if (g != null)
			{
				g.x1(A_2);
				g.xz(A_1);
				g.x3(this);
				base.a8().Zone.ActionManager.g9(g, atp.a);
				dz6.a(g);
			}
		}
	}

	// Token: 0x06006EA0 RID: 28320 RVA: 0x002E56EC File Offset: 0x002E38EC
	private void a(string A_0, els A_1, Dictionary<string, object> A_2 = null)
	{
		if (!string.IsNullOrEmpty(A_0))
		{
			cze cze = dv0.a(A_0);
			if (cze != null)
			{
				if (A_2 == null)
				{
					A_2 = new Dictionary<string, object>();
				}
				else
				{
					A_2 = new Dictionary<string, object>(A_2);
				}
				A_2["StatusEffect"] = A_1;
				a4s a_ = new a4s(cze, null, new ar7(base.a8()), A_2);
				base.a8().Zone.ActionManager.g9(a_, atp.a);
			}
		}
	}

	// Token: 0x06006EA1 RID: 28321 RVA: 0x002E5764 File Offset: 0x002E3964
	private void q()
	{
		if (base.a8().i.b != null)
		{
			base.a8().i.b.a(m7.d, true, false);
		}
	}

	// Token: 0x06006EA2 RID: 28322 RVA: 0x002E5794 File Offset: 0x002E3994
	private void p()
	{
	}

	// Token: 0x06006EA3 RID: 28323 RVA: 0x002E5798 File Offset: 0x002E3998
	private void o()
	{
	}

	// Token: 0x06006EA4 RID: 28324 RVA: 0x002E57A0 File Offset: 0x002E39A0
	private void n()
	{
		if (this.aa() != null)
		{
			this.n = this.aa().SpecialStates.b();
		}
	}

	// Token: 0x06006EA5 RID: 28325 RVA: 0x002E57D0 File Offset: 0x002E39D0
	private void m()
	{
		if (this.aa() != null)
		{
			if (!this.n.f && this.aa().SpecialStates.f)
			{
				this.g();
			}
			if (!this.n.b && this.aa().SpecialStates.b)
			{
				this.h();
			}
			if (!this.n.c && this.aa().SpecialStates.c)
			{
				this.i();
			}
			if (!this.n.e && this.aa().SpecialStates.e)
			{
				this.j();
			}
			if (!this.n.d && this.aa().SpecialStates.d)
			{
				this.k();
			}
			if (!this.n.a && this.aa().SpecialStates.a)
			{
				this.l();
			}
		}
	}

	// Token: 0x06006EA6 RID: 28326 RVA: 0x002E58EC File Offset: 0x002E3AEC
	private void l()
	{
		if (base.a8().i.b != null)
		{
			base.a8().i.b.a(m7.b | m7.i, true, false);
		}
	}

	// Token: 0x06006EA7 RID: 28327 RVA: 0x002E5920 File Offset: 0x002E3B20
	private void k()
	{
		if (base.a8().i.b != null)
		{
			base.a8().i.b.a(m7.f | m7.i, true, false);
		}
	}

	// Token: 0x06006EA8 RID: 28328 RVA: 0x002E5954 File Offset: 0x002E3B54
	private void j()
	{
	}

	// Token: 0x06006EA9 RID: 28329 RVA: 0x002E5958 File Offset: 0x002E3B58
	private void i()
	{
		if (base.a8().i.b != null)
		{
			base.a8().i.b.a(m7.b | m7.i, true, false);
		}
	}

	// Token: 0x06006EAA RID: 28330 RVA: 0x002E598C File Offset: 0x002E3B8C
	private void h()
	{
		if (base.a8().i.b != null)
		{
			base.a8().i.b.a(m7.e | m7.i, true, false);
		}
	}

	// Token: 0x06006EAB RID: 28331 RVA: 0x002E59C0 File Offset: 0x002E3BC0
	private void g()
	{
		if (base.a8().i.b != null)
		{
			base.a8().i.b.a(m7.d | m7.i, true, false);
		}
	}

	// Token: 0x06006EAC RID: 28332 RVA: 0x002E59F4 File Offset: 0x002E3BF4
	private void f()
	{
		if (base.a8().i.b != null)
		{
			em1 em = this.a(base.a8().i.b.a());
			if (em != null)
			{
				em.m();
			}
		}
	}

	// Token: 0x06006EAD RID: 28333 RVA: 0x002E5A40 File Offset: 0x002E3C40
	private void e()
	{
		c6g c6g = Enumerable.FirstOrDefault<c6g>(Enumerable.OfType<c6g>(base.a8().RaysEmitters));
		if (c6g != null)
		{
			c6g.Definition.Range = this.aa().SightRange;
			c6g.ii(true);
		}
	}

	// Token: 0x06006EAE RID: 28334 RVA: 0x002E5A88 File Offset: 0x002E3C88
	private em1 a(auv A_0)
	{
		qy qy = A_0 as qy;
		if (qy != null && qy.aa() != null)
		{
			return this.a(qy.aa());
		}
		return A_0 as em1;
	}

	// Token: 0x06006EAF RID: 28335 RVA: 0x002E5AC0 File Offset: 0x002E3CC0
	private void a(List<ak1> A_0)
	{
		int num = c2h.c(this.aa());
		int num2 = global::qw.a(this.aa());
		bool flag = base.a8().IsPlayer;
		if (flag)
		{
			num2 = (int)((double)num2 * aiy.r);
		}
		foreach (ak1 ak in A_0)
		{
			double num3 = 1.0;
			float num4 = bnx.a(base.a8().aj().a(), ak.Location);
			if (num4 > 3f)
			{
				num3 += (double)(num4 - 3f) * 0.1;
			}
			if (num3 < 0.25)
			{
				num3 = 0.25;
			}
			foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
			{
				c5x c5x = b0b as c5x;
				if (c5x != null)
				{
					if (c5x.r != null && c5x.r.b != null)
					{
						ed2 ed = c5x.r.b as ed2;
						if (ed != null)
						{
							if (!ed.a.Contains(base.a8().qe()) && (this.aa().Truesighted || num2 >= ed.c))
							{
								bool flag2;
								if (this.aa().Truesighted || !(this.aa() is e3q))
								{
									flag2 = true;
								}
								else
								{
									double num5 = d05.b(0.25, (double)num2 / (double)Math.Max(1, ed.c) * 0.35, 0.85);
									flag2 = (cuo.a.NextDouble() < num5);
								}
								if (flag2)
								{
									ed.a.Add(base.a8().qe());
									if (flag)
									{
										c5x.r.b.a(base.a8(), false, false);
										bmj.a(c5x, new d53("Обнаружена ловушка!", adi.i, null, false));
									}
									else if (ed.f == asp.a && ed.a() != null && eir.a(c5x.Zone, this.aa().FactionId) == ZoneControlLevel.Controlled)
									{
										awq.a(this, ed.a(), false, false, null, true, false, false, false);
									}
									if (base.a8().i.b != null)
									{
										base.a8().i.b.a(m7.e, true, false);
									}
								}
							}
						}
						else if (flag && !c5x.r.b.j())
						{
							int num6 = Convert.ToInt32(num3 * (double)c5x.r.b.g());
							if (num >= num6 && c5x.r.b.a(base.a8(), false, false))
							{
								if (!string.IsNullOrEmpty(c5x.r.b.m()))
								{
									a7v.a(new aqt(c5x.r.b.m()));
									bmj.a(c5x.r.b.l(), new d53("Вы обнаруживаете " + c5x.r.b.m(), adi.g, null, false));
								}
								if (!string.IsNullOrEmpty(c5x.r.b.k()))
								{
									c5x.c();
									c5x.v.b.a("reveal", c5x.r.b.k(), 1f, c9z.a, false, false);
								}
								int num7 = (int)((double)c2h.c(num6, c2h.d(this.aa())) * c5x.r.b.p());
								if (num7 > 0)
								{
									e3q e3q = this.aa() as e3q;
									if (e3q != null && e3q.e() == ExperienceSystem.Classic)
									{
										this.a(num7, null);
									}
									cxc.a(eyy.bp);
								}
							}
						}
					}
					cij aspect = c5x.GetAspect<cij>();
					if (aspect != null && aspect.f() != null && eir.a(c5x.Zone, this.aa().FactionId) == ZoneControlLevel.Controlled)
					{
						awq.a(this, aspect.f(), false, false, null, true, false, false, false);
					}
				}
			}
		}
	}

	// Token: 0x06006EB0 RID: 28336 RVA: 0x002E5FB0 File Offset: 0x002E41B0
	private void a(cwt A_0, List<csk> A_1)
	{
		if (!A_0.r && !A_0.s && base.a8().i.b != null)
		{
			ad5 ad = base.a8().i.b.a() as ad5;
			if (ad != null)
			{
				eu7 eu = ad.e();
				if (eu != null && eu.c() != bna.a)
				{
					v2 v = ad.aa() as v2;
					if (v != null)
					{
						int num = 0;
						if (eu.c() == bna.b)
						{
							bd0 bd = eu as bd0;
							if (bd != null)
							{
								num = euf.a(A_0, A_1, this.aa(), bd.b(), v.j2());
							}
						}
						else if (eu.c() == bna.c)
						{
							num = euf.a(A_0, A_1, this.aa(), v.j2());
						}
						num = (int)((float)num * eu.j());
						if (num > 0)
						{
							v.j3(num);
						}
					}
				}
			}
		}
	}

	// Token: 0x06006EB1 RID: 28337 RVA: 0x002E60AC File Offset: 0x002E42AC
	private void a(cwt A_0, List<csk> A_1, cru A_2)
	{
		Dictionary<string, object> dictionary = a3f.a(base.a8());
		dictionary["attackResult"] = A_0;
		dictionary["damage"] = A_1;
		dictionary["stats"] = A_2;
		if (this.w != null)
		{
			foreach (cze cze in this.w)
			{
				cze.ym(null, base.a8(), dictionary);
			}
		}
		Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
		dictionary2["attackResult"] = A_0;
		dictionary2["damage"] = A_1;
		dictionary2["stats"] = A_2;
		foreach (els els in Enumerable.ToList<els>(this.aa().StatusEffects.d()))
		{
			if (els.ae != null)
			{
				this.a(els.ae, els, dictionary2);
			}
		}
	}

	// Token: 0x06006EB2 RID: 28338 RVA: 0x002E61DC File Offset: 0x002E43DC
	private void d()
	{
		if (this.aa().IsInControl && (this.@as() || this.aa().b(d8o.b | d8o.d | d8o.h)))
		{
			this.ac += (double)((aiy.a6 + 100 - cuo.a.Next(200)) * (((base.a8().g & e2b.d) != (e2b)0) ? 1 : 2));
			List<ak1> a_ = this.y();
			this.a(a_);
		}
	}

	// Token: 0x06006EB3 RID: 28339 RVA: 0x002E6268 File Offset: 0x002E4468
	private void b()
	{
		cnk service = bpo.GetService<cnk>();
		if (service != null && service.aqu() != null)
		{
			cky cky = service.aqu().ac().abu(asp.av, asp.a);
			if (cky != null)
			{
				if (this.aa().Gear.l().Item != null && this.aa().Gear.l().Item.fu().a5() == "rathoundRegalia")
				{
					if (cky.a != global::h.d)
					{
						service.aqu().ac().abw(asp.a, asp.av, global::h.d, null, true, false);
					}
				}
				else if (cky.a != global::h.a)
				{
					service.aqu().ac().abw(asp.a, asp.av, global::h.a, null, true, false);
				}
			}
			cky cky2 = service.aqu().ac().abu(asp.d9, asp.a);
			if (cky2 != null)
			{
				if (Enumerable.Sum<d5o>(this.aa().Gear.i().a("ccResearchFacilityPass", 1), new Func<d5o, int>(amc.a.a.a)) >= 1)
				{
					if (cky2.a != global::h.d)
					{
						service.aqu().ac().abw(asp.a, asp.d9, global::h.d, null, true, false);
						return;
					}
				}
				else if (cky2.a != global::h.a)
				{
					service.aqu().ac().abw(asp.a, asp.d9, global::h.a, null, true, false);
				}
			}
		}
	}

	// Token: 0x06006EB4 RID: 28340 RVA: 0x002E6430 File Offset: 0x002E4630
	private void c(float A_0)
	{
		if (!this.aa().b(d8o.l | d8o.n) && (this.a0 -= (double)A_0) <= 0.0)
		{
			this.a0 += amc.d;
			double num = 0.0;
			string text = null;
			Vector3 vector = base.a8().aj();
			Point a_ = new Point((int)vector.X, (int)vector.Y);
			ak1 ak = base.a8().Area.a(a_);
			if (ak != null)
			{
				sd sd = null;
				List<ya> list = ak.a(typeof(sd));
				if (list != null)
				{
					sd = (Enumerable.FirstOrDefault<ya>(list) as sd);
				}
				if (sd != null)
				{
					num = sd.a();
					if (!string.IsNullOrEmpty(sd.b()))
					{
						text = sd.b();
					}
				}
				else
				{
					foreach (b0b b0b in ak.c.Values)
					{
						c5x c5x = (c5x)b0b;
						if (!c5x.IsFloor)
						{
							break;
						}
						if (aw1.a(c5x, vector.b()))
						{
							awy aspect = c5x.GetAspect<awy>();
							if (aspect != null)
							{
								num = aspect.b();
								if (!string.IsNullOrEmpty(aspect.a()))
								{
									text = aspect.a();
								}
							}
						}
					}
				}
			}
			if (num > 0.0)
			{
				if (cuo.a.NextDouble() >= num)
				{
					return;
				}
				Point point = new Point((int)(vector.X * 4f), (int)(vector.Y * 4f));
				Vector3 vector2 = new Vector3((float)point.X / 4f, (float)point.Y / 4f, 0f);
				if (!string.IsNullOrEmpty(text))
				{
					boj.a(base.a8().Area, vector2, null, text, 1, double.MaxValue, null, null, null, null);
					return;
				}
				using (List<KeyValuePair<string, float>>.Enumerator enumerator2 = boj.a(ak, true).GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						KeyValuePair<string, float> keyValuePair = enumerator2.Current;
						float? num2 = null;
						if (keyValuePair.Value != 1f)
						{
							num2 = new float?(keyValuePair.Value);
						}
						aud a_2 = base.a8().Area;
						Vector3 a_3 = vector2;
						HorizontalDirection? a_4 = null;
						string a_5 = "WaterStep" + keyValuePair.Key;
						int a_6 = 1;
						double maxValue = double.MaxValue;
						float? a_7 = num2;
						boj.a(a_2, a_3, a_4, a_5, a_6, maxValue, null, a_7, null, null);
					}
					return;
				}
			}
			this.a0 = 0.0;
		}
	}

	// Token: 0x06006EB5 RID: 28341 RVA: 0x002E6768 File Offset: 0x002E4968
	private void b(float A_0)
	{
		if (this.aa().b(d8o.n) && (this.a0 -= (double)A_0) <= 0.0)
		{
			this.a0 += 0.8;
			foreach (KeyValuePair<string, float> keyValuePair in boj.a(Enumerable.FirstOrDefault<ak1>(base.a8().l), true))
			{
				c5x c5x;
				if (keyValuePair.Value == 1f)
				{
					c5x a_ = base.a8();
					string a_2 = "ShallowWaterBackWave" + keyValuePair.Key;
					int a_3 = 1;
					double maxValue = double.MaxValue;
					bool a_4 = true;
					bool a_5 = false;
					float? a_6 = dz6.a();
					c5x = boj.a(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false);
				}
				else
				{
					c5x a_7 = base.a8();
					string a_8 = "ShallowWaterBackWave" + keyValuePair.Key;
					int a_9 = 1;
					double maxValue2 = double.MaxValue;
					bool a_10 = true;
					bool a_11 = false;
					float? a_6 = dz6.a();
					float? a_12 = new float?(keyValuePair.Value);
					c5x = boj.a(a_7, a_8, a_9, maxValue2, a_10, a_11, null, null, a_12, a_6, false);
				}
				if (c5x != null)
				{
					c5x.o.b.b = new Point(0, base.a8().ac);
					c5x.b(aju.b3);
					c5x.Location = new Vector3(c5x.Location.X, c5x.Location.Y, -0.2f);
					c5x.VisualPriority = -101;
					c5x.x = true;
					c5x.Size = new Vector3(0.1f, 0.1f, 0.1f);
					c5x.ah();
					dha aspect = c5x.GetAspect<dha>();
					if (aspect != null)
					{
						aspect.b(true);
					}
				}
			}
		}
	}

	// Token: 0x06006EB6 RID: 28342 RVA: 0x002E698C File Offset: 0x002E4B8C
	private void a(float A_0)
	{
		if ((this.a1 -= (double)A_0) <= 0.0)
		{
			this.a1 += 0.8;
			lh lh = ckw.a(base.a8());
			if (lh != null)
			{
				lh.mg(base.a8());
			}
		}
	}

	// Token: 0x06006EB7 RID: 28343 RVA: 0x002E69F0 File Offset: 0x002E4BF0
	private void a(int A_0)
	{
		aiw aiw = Enumerable.FirstOrDefault<aiw>(this.aa().StatusEffects.Get<aiw>());
		if (aiw != null && aiw.TimeLeft > (double)d0u.b)
		{
			Point point = base.a8().aj().a();
			for (int i = point.X - 1; i <= point.X + 1; i++)
			{
				for (int j = point.Y - 1; j <= point.Y + 1; j++)
				{
					ak1 ak = base.a8().Area.b(i, j);
					if (ak != null && (!ak.Formation.c(2L) || (ak.Formation.c(1048704L) && !ak.Formation.c(4L))))
					{
						dd5.a(this, ak, 1.0, A_0, false);
					}
				}
			}
		}
	}

	// Token: 0x06006EB8 RID: 28344 RVA: 0x002E6AE4 File Offset: 0x002E4CE4
	private void d(double A_0)
	{
		if (this.aa().Vehicle != null && this.af() != CharacterState.Move)
		{
			this.ay.a(base.a8(), this.aa().Vehicle, A_0);
			return;
		}
		this.ay.a(base.a8());
	}

	// Token: 0x06006EB9 RID: 28345 RVA: 0x002E6B3C File Offset: 0x002E4D3C
	private void c(double A_0)
	{
		aru aru = base.a8().c();
		if (this.aa().Vehicle == null || this.af() != CharacterState.Move)
		{
			this.az = 0f;
		}
		else
		{
			float num = (float)d05.b(0.35, this.aa().Vehicle.m() / 5.0, 1.0);
			this.az = num;
		}
		app app;
		aru.e().TryGetValue("vehicleMovementSound", out app);
		if (app == null)
		{
			if (this.az != 0f)
			{
				float a_ = (float)(A_0 * (double)amc.c);
				aru.a("vehicleMovementSound", "xpbl_JetskiWater", a_, c9z.a, true, false);
			}
		}
		else
		{
			float num2 = app.b();
			if (num2 != this.az)
			{
				if (this.az > num2)
				{
					num2 = (float)Math.Min((double)this.az, (double)num2 + A_0 * (double)amc.c);
				}
				else
				{
					num2 = (float)Math.Max((double)this.az, (double)num2 - A_0 * (double)amc.c);
				}
				aru.a("vehicleMovementSound", num2);
			}
		}
		if (this.aa().Vehicle != null)
		{
			float num3 = 0.65f + 0.35f * this.az;
			foreach (drm drm in this.aa().Vehicle.x())
			{
				string a_2 = string.Format("vehicle_{0}", drm.a);
				aru.a(a_2, drm.c * num3);
			}
		}
	}

	// Token: 0x06006EBA RID: 28346 RVA: 0x002E6D10 File Offset: 0x002E4F10
	private void b(double A_0)
	{
		if ((this.a5 -= A_0) <= 0.0)
		{
			this.a(A_0);
		}
	}

	// Token: 0x06006EBB RID: 28347 RVA: 0x002E6D44 File Offset: 0x002E4F44
	private void a(double A_0 = 0.0)
	{
		if (this.aa().StatusEffects.a(bk9.a))
		{
			List<anc> list = new List<anc>();
			HashSet<Guid> hashSet = new HashSet<Guid>();
			foreach (ak1 ak in base.a8().l)
			{
				if (aw1.a(base.a8(), ak) < 0.75)
				{
					foreach (b0b b0b in ak.c.Values)
					{
						c5x c5x = (c5x)b0b;
						if (!hashSet.Contains(c5x.qe()))
						{
							hashSet.Add(c5x.qe());
							if (c5x.y.b != null)
							{
								list.Add(c5x.y.b);
							}
						}
					}
				}
			}
			if (list.Count > 0)
			{
				foreach (anc anc in list)
				{
					anc.a(base.a8());
				}
			}
		}
		this.a5 = (double)(50 + cuo.a.Next(50));
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary["milisecondsPassed"] = A_0;
		foreach (cze cze in this.z)
		{
			cze.ym(base.a8(), base.a8(), dictionary);
		}
		Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
		dictionary2["milisecondsPassed"] = A_0;
		foreach (els els in Enumerable.ToList<els>(this.aa().StatusEffects.d()))
		{
			if (els.ad != null)
			{
				this.a(els.ad, els, dictionary2);
			}
		}
	}

	// Token: 0x06006EBC RID: 28348 RVA: 0x002E6FD0 File Offset: 0x002E51D0
	private void a(eds A_0)
	{
		if (this.a2 != this.a3 && (this.a4 -= A_0.b.TotalMilliseconds) < 0.0)
		{
			this.a4 = 1000.0;
			if (base.a8() != null && base.a8().j == cgy.b && base.a8().Area != null && base.a8().c(dm9.b))
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
				{
					bm6 aspect = serviceOrThrow.aqu().v().b().GetAspect<bm6>();
					if (aspect != null)
					{
						erl erl = aspect.c(this);
						if (erl != null && erl.f() == cem.d)
						{
							bpo.GetServiceOrThrow<e5f>().ash(this.a2, null);
							this.a3 = this.a2;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006EBD RID: 28349 RVA: 0x002E70F8 File Offset: 0x002E52F8
	[dcc("CEA:mSE_SER")]
	private void d(object A_0, dwu A_1)
	{
		if (this.r())
		{
			cf9 cf = a4p.a(A_1.b());
			if (cf != null)
			{
				cf.r2(A_1.b(), this);
				return;
			}
			this.a(A_1.b().RemovedAction, A_1.b(), A_1.c());
			this.a(A_1.b().aa, A_1.b(), null);
		}
	}

	// Token: 0x06006EBE RID: 28350 RVA: 0x002E7168 File Offset: 0x002E5368
	[dcc("CEA:mSE_SEE")]
	private void c(object A_0, dwu A_1)
	{
		if (this.r())
		{
			cf9 cf = a4p.a(A_1.b());
			if (cf != null)
			{
				cf.r0(A_1.b(), this);
				return;
			}
			this.a(A_1.b().ExpiredAction, A_1.b(), A_1.c());
			this.a(A_1.b().y, A_1.b(), null);
		}
	}

	// Token: 0x06006EBF RID: 28351 RVA: 0x002E71D8 File Offset: 0x002E53D8
	[dcc("CEA:mSE_SET")]
	private void b(object A_0, dwu A_1)
	{
		if (A_1.b() != null && !A_1.b().ah)
		{
			this.a(A_1.b(), A_1.c());
		}
	}

	// Token: 0x06006EC0 RID: 28352 RVA: 0x002E7214 File Offset: 0x002E5414
	public void a(els A_0)
	{
		this.a(A_0, this.aa().StatusEffects.e());
	}

	// Token: 0x06006EC1 RID: 28353 RVA: 0x002E7238 File Offset: 0x002E5438
	public void a(els A_0, ll A_1)
	{
		if (A_0 != null && this.r())
		{
			cf9 cf = a4p.a(A_0);
			if (cf != null)
			{
				cf.r1(A_0, this);
				return;
			}
			this.a(A_0.TickAction, A_0, A_1);
			this.a(A_0.z, A_0, null);
		}
	}

	// Token: 0x06006EC2 RID: 28354 RVA: 0x002E7288 File Offset: 0x002E5488
	[dcc("CEA:mSE_SEA")]
	private void a(object A_0, dwu A_1)
	{
		if (!A_1.b().Silent && !A_1.a())
		{
			bmj.a(base.a8(), new bpf(A_1.b()));
		}
		if (this.r())
		{
			cf9 cf = a4p.a(A_1.b());
			if (cf != null)
			{
				cf.rz(A_1.b(), this);
				return;
			}
			this.a(A_1.b().AppliedAction, A_1.b(), A_1.c());
			this.a(A_1.b().ab, A_1.b(), null);
		}
	}

	// Token: 0x06006EC3 RID: 28355 RVA: 0x002E7328 File Offset: 0x002E5528
	[dcc("CEA:mO_CWS")]
	private void b(object A_0, EventArgs A_1)
	{
		this.q();
		this.s();
	}

	// Token: 0x06006EC4 RID: 28356 RVA: 0x002E7338 File Offset: 0x002E5538
	[dcc("CEA:mO_PA")]
	private void b(object A_0, ax0 A_1)
	{
		aeq aeq = null;
		if (A_1.a() > 0f)
		{
			int num = (int)A_1.a();
			aeq = new at(new ap9(this.aa()), num);
			bmj.a(base.a8(), new e3f(num));
		}
		else if (A_1.a() < 0f)
		{
			int num2 = (int)Math.Abs(A_1.a());
			aeq = new a5s(new ap9(this.aa()), num2);
			bmj.a(base.a8(), new emx(num2));
		}
		if (aeq != null)
		{
			bey.a(aeq, this.aa(), this);
			a7v.a(aeq);
		}
	}

	// Token: 0x06006EC5 RID: 28357 RVA: 0x002E73E0 File Offset: 0x002E55E0
	[dcc("CEA:mO_PRA")]
	private void a(object A_0, ax0 A_1)
	{
		aeq aeq = null;
		if (A_1.a() > 0f)
		{
			int num = (int)A_1.a();
			aeq = new dbg(new ap9(this.aa()), num);
			bmj.a(base.a8(), new cyd(num));
		}
		else if (A_1.a() < 0f)
		{
			int num2 = (int)Math.Abs(A_1.a());
			aeq = new ahd(new ap9(this.aa()), num2);
			bmj.a(base.a8(), new dru(num2));
		}
		if (aeq != null)
		{
			bey.a(aeq, this.aa(), this);
			a7v.a(aeq);
		}
	}

	// Token: 0x06006EC6 RID: 28358 RVA: 0x002E7488 File Offset: 0x002E5688
	[dcc("CEA:mD_CTD")]
	private void g(object A_0, dj7 A_1)
	{
		HashSet<CombatSpeakEvent> hashSet = new HashSet<CombatSpeakEvent>();
		int num;
		if (A_1.a() != null && A_1.a().Count > 0)
		{
			num = Enumerable.Sum<csk>(A_1.a(), new Func<csk, int>(amc.a.a.b));
		}
		else
		{
			num = 0;
		}
		if (A_1.e() != null)
		{
			d2d a_ = new d2d(A_1.e(), A_1.a());
			bey.a(a_, A_1.e(), this);
			a7v.a(a_);
			List<csk> list = new List<csk>();
			if (bpo.GetServiceOrThrow<cnk>().aq1().b().w().f())
			{
				using (List<csk>.Enumerator enumerator = A_1.a().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						amc.e e = new amc.e();
						e.a = enumerator.Current;
						int num2 = list.FindIndex(new Predicate<csk>(e.a));
						if (num2 != -1)
						{
							list[num2] = new csk(e.a.DamageType, list[num2].Amount + e.a.Amount);
						}
						else
						{
							list.Add(e.a);
						}
					}
					goto IL_160;
				}
			}
			list.AddRange(A_1.a());
			IL_160:
			foreach (csk a_2 in list)
			{
				bmj.a(base.a8(), new bfa(a_2, A_1.e().e, A_1.e().r, base.a8().c(e2b.d)));
			}
			this.a(A_1.e(), A_1.a(), A_1.c());
			if (num > 0 && A_1.e().b)
			{
				if (!A_1.e().w && A_1.e().i != null && A_1.e().i.b == asp.a && this.aa().c(d8o.u))
				{
					hashSet.Add(CombatSpeakEvent.Hit_Companion);
				}
				if ((double)((float)num / Math.Max(1f, this.aa().Defense.q().zm())) > 0.2 || num > 30)
				{
					if (!A_1.e().w)
					{
						hashSet.Add(CombatSpeakEvent.Hit_General);
					}
					if ((double)euf.f(this.aa()) < 0.15)
					{
						hashSet.Add(CombatSpeakEvent.Hit_LowHealth);
					}
					if (A_1.e().e)
					{
						hashSet.Add(CombatSpeakEvent.Hit_CriticallyHit);
					}
					if (eub.f(A_1.e().x) || (A_1.e().ae != null && euf.g(A_1.e().ae.Value)))
					{
						hashSet.Add(CombatSpeakEvent.Hit_Firearm);
					}
					int num3 = Enumerable.Sum<csk>(Enumerable.Where<csk>(A_1.a(), new Func<csk, bool>(amc.a.a.o)), new Func<csk, int>(amc.a.a.d));
					if (num3 > 0 && (double)num3 / (double)num >= 0.5)
					{
						hashSet.Add(CombatSpeakEvent.Hit_BurningSensation);
					}
					int num4 = Enumerable.Sum<csk>(Enumerable.Where<csk>(A_1.a(), new Func<csk, bool>(amc.a.a.e)), new Func<csk, int>(amc.a.a.h));
					if (num4 > 0 && (double)num4 / (double)num >= 0.5)
					{
						hashSet.Add(CombatSpeakEvent.Hit_Frost);
					}
					int num5 = Enumerable.Sum<csk>(Enumerable.Where<csk>(A_1.a(), new Func<csk, bool>(amc.a.a.g)), new Func<csk, int>(amc.a.a.r));
					if (num5 > 0 && (double)num5 / (double)num >= 0.5)
					{
						hashSet.Add(CombatSpeakEvent.Hit_BurningSensation);
					}
					int num6 = Enumerable.Sum<csk>(Enumerable.Where<csk>(A_1.a(), new Func<csk, bool>(amc.a.a.c)), new Func<csk, int>(amc.a.a.j));
					if (num6 > 0 && (double)num6 / (double)num >= 0.5)
					{
						hashSet.Add(CombatSpeakEvent.Hit_BurningSensation);
					}
					if (A_1.e().ad.GetPrimitivePropertyValue<PsiSchool>("PsionicSource", null).GetValueOrDefault() == PsiSchool.ThoughtControl)
					{
						hashSet.Add(CombatSpeakEvent.Hit_Mind);
					}
					if (euf.d(A_1.e().x) || euf.d(A_1.e().ae) || euf.c(A_1.e().ae))
					{
						hashSet.Add(CombatSpeakEvent.Hit_MeleeBlunt);
					}
					if (A_1.e().x == AmmoType.Knife || A_1.e().x == AmmoType.Dagger || A_1.e().ae.GetValueOrDefault() == WeaponSubtype.Knife || A_1.e().ae.GetValueOrDefault() == WeaponSubtype.Dagger || A_1.e().ae.GetValueOrDefault() == WeaponSubtype.SerratedKnife || A_1.e().ae.GetValueOrDefault() == WeaponSubtype.Spear || A_1.e().ae.GetValueOrDefault() == WeaponSubtype.Sword || A_1.e().ae.GetValueOrDefault() == WeaponSubtype.Machete_Straight || A_1.e().ae.GetValueOrDefault() == WeaponSubtype.Machete_Curved)
					{
						hashSet.Add(CombatSpeakEvent.Hit_MeleeSharp);
					}
					if (A_1.e().x == AmmoType.Sledgehammer || A_1.e().ae.GetValueOrDefault() == WeaponSubtype.Sledgehammer)
					{
						hashSet.Add(CombatSpeakEvent.Hit_MeleeBlunt);
					}
					if (eub.f(A_1.e().x) || (A_1.e().ae != null && euf.g(A_1.e().ae.Value)))
					{
						hashSet.Add(CombatSpeakEvent.Hit_Firearm);
					}
					if (A_1.e().x == AmmoType.Energy || A_1.e().ae.GetValueOrDefault() == WeaponSubtype.Pistol_Laser || A_1.e().ae.GetValueOrDefault() == WeaponSubtype.Pistol_Plasma || A_1.e().ad.GetPrimitivePropertyValue<bool>("IsEnergyWeapon", new bool?(false)).Value)
					{
						hashSet.Add(CombatSpeakEvent.Hit_BurningSensation);
					}
					if ((A_1.e().x >= AmmoType.Vial_Acid && A_1.e().x < (AmmoType)2000) || A_1.e().ad.GetPrimitivePropertyValue<bool>("IsAcidWeapon", new bool?(false)).Value)
					{
						hashSet.Add(CombatSpeakEvent.Hit_BurningSensation);
					}
					if (A_1.e().x == AmmoType.Bolts || A_1.e().ae.GetValueOrDefault() == WeaponSubtype.Crossbow)
					{
						hashSet.Add(CombatSpeakEvent.Hit_Bolt);
					}
					if (A_1.e().ad.GetPrimitivePropertyValue<bool>("IsCaltrop", new bool?(false)).Value)
					{
						hashSet.Add(CombatSpeakEvent.Hit_Caltrops);
					}
					if (A_1.e().ad.GetPrimitivePropertyValue<bool>("IsBearTrap", new bool?(false)).Value)
					{
						hashSet.Add(CombatSpeakEvent.Hit_BearTrap);
					}
					if (A_1.e().ad.GetPrimitivePropertyValue<bool>("IsToxicGas", new bool?(false)).Value)
					{
						hashSet.Add(CombatSpeakEvent.Hit_ToxicGas);
					}
				}
			}
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary["attackResult"] = A_1.e();
			dictionary["damage"] = A_1.a();
			dictionary["stats"] = A_1.c();
			foreach (els els in Enumerable.ToList<els>(this.aa().StatusEffects.d()))
			{
				if (els.af != null)
				{
					this.a(els.af, els, dictionary);
				}
			}
		}
		if (this.aa() is e3q && this.aa().Defense.q().zo() == 1f && num > 0)
		{
			cxc.c(eyy.ar);
		}
		if (hashSet.Count > 0 && !this.aa().SpecialStates.a && !this.aa().SpecialStates.h && (A_1.c() == null || !A_1.c().c))
		{
			a20.a(base.a8(), A_1.e().i, Enumerable.ToArray<CombatSpeakEvent>(hashSet));
		}
		cxc.a["Player_Missed_Count"] = 0;
		lh lh = ckw.a(base.a8());
		if (lh != null)
		{
			lh.qt(this, A_1);
		}
		if (A_1.e().q && A_1.c() != null && A_1.c().a != null && A_1.c().a.Count > 0 && this.aa().Feats.Contains<d3h>())
		{
			if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_1.c().a, new Func<csk, bool>(amc.a.a.l)), new Func<csk, int>(amc.a.a.k)) > 0)
			{
				dd0 a_3 = new dd0(d3h.b(this.aa()), d3h.c(this.aa()), d3h.a(this.aa()));
				this.aa().StatusEffects.a(a_3, false, false, false);
			}
		}
	}

	// Token: 0x06006EC7 RID: 28359 RVA: 0x002E8008 File Offset: 0x002E6208
	[dcc("CEA:mD_CED")]
	private void f(object A_0, dj7 A_1)
	{
		if (A_1.e() != null)
		{
			exp a_ = new exp(A_1.e(), A_1.a());
			bey.a(a_, A_1.e(), this);
			a7v.a(a_);
			this.a(A_1.e(), A_1.a(), A_1.c());
		}
	}

	// Token: 0x06006EC8 RID: 28360 RVA: 0x002E805C File Offset: 0x002E625C
	[dcc("CEA:mD_CSD")]
	private void e(object A_0, dj7 A_1)
	{
		if (A_1.e() != null)
		{
			c1u a_ = new c1u(A_1.e(), A_1.a());
			bey.a(a_, A_1.e(), this);
			a7v.a(a_);
			bi2 a_2 = new bi2(Enumerable.Sum<csk>(A_1.a(), new Func<csk, int>(amc.a.a.m)), A_1.e().e);
			bmj.a(base.a8(), a_2);
			this.a(A_1.e(), A_1.a(), A_1.c());
			if (base.a8().i.b != null)
			{
				base.a8().i.b.a(m7.i, true, false);
			}
			if (A_1.a() != null && A_1.b() != null && !this.aa().SpecialStates.a && !this.aa().SpecialStates.h && !this.aa().SpecialStates.c)
			{
				if (Enumerable.Sum<csk>(A_1.b(), new Func<csk, int>(amc.a.a.f)) == 0)
				{
					a20.a(base.a8(), A_1.e().i, new CombatSpeakEvent[]
					{
						CombatSpeakEvent.Hit_ShieldedAll
					});
				}
			}
		}
	}

	// Token: 0x06006EC9 RID: 28361 RVA: 0x002E81D8 File Offset: 0x002E63D8
	[dcc("CEA:mD_CRD")]
	private void d(object A_0, dj7 A_1)
	{
		if (A_1.e() != null)
		{
			dfu a_ = new dfu(A_1.e(), A_1.a());
			if (!A_1.c().c && this.aa().Feats.Contains<e6h>())
			{
				int num = Enumerable.Sum<csk>(Enumerable.Where<csk>(A_1.a(), new Func<csk, bool>(amc.a.a.a)), new Func<csk, int>(amc.a.a.p));
				if (num > 0)
				{
					ah8 a_2 = new ah8(d0u.b * 2, Math.Max(1, num / 3));
					this.aa().StatusEffects.a(a_2, false, false, false);
				}
			}
			bey.a(a_, A_1.e(), this);
			a7v.a(a_);
			this.a(A_1.e(), A_1.a(), A_1.c());
			if (base.a8().i.b != null)
			{
				base.a8().i.b.a(m7.i, true, false);
			}
			if (!A_1.e().w && A_1.a() != null && A_1.b() != null && this.aa().IsInControl && !this.aa().SpecialStates.a && !this.aa().SpecialStates.h && !this.aa().SpecialStates.c)
			{
				if (Enumerable.Sum<csk>(A_1.b(), new Func<csk, int>(amc.a.a.n)) == 0 && (A_1.c() == null || !A_1.c().c))
				{
					a20.a(base.a8(), A_1.e().i, new CombatSpeakEvent[]
					{
						CombatSpeakEvent.Hit_ResistedAll
					});
				}
			}
		}
		lh lh = ckw.a(base.a8());
		if (lh != null)
		{
			lh.qs(this, A_1);
		}
	}

	// Token: 0x06006ECA RID: 28362 RVA: 0x002E8408 File Offset: 0x002E6608
	[dcc("CEA:mD_CBD")]
	private void c(object A_0, dj7 A_1)
	{
		if (A_1.e() != null)
		{
			eqb a_ = new eqb(A_1.e(), A_1.a());
			bey.a(a_, A_1.e(), this);
			a7v.a(a_);
			foreach (csk a_2 in A_1.a())
			{
				bmj.a(base.a8(), new emm(a_2, base.a8().c(e2b.d)));
			}
			this.a(A_1.e(), A_1.a(), A_1.c());
			if (A_1.a() != null && A_1.b() != null && !this.aa().SpecialStates.a && !this.aa().SpecialStates.h && !this.aa().SpecialStates.c)
			{
				if (Enumerable.Sum<csk>(A_1.b(), new Func<csk, int>(amc.a.a.q)) == 0 && (A_1.c() == null || !A_1.c().c))
				{
					a20.a(base.a8(), A_1.e().i, new CombatSpeakEvent[]
					{
						CombatSpeakEvent.Hit_BlockedAll
					});
				}
			}
		}
		if (A_1.c() != null && A_1.c().d)
		{
			int num = 1;
			a3w a3w = Enumerable.FirstOrDefault<a3w>(this.aa().StatusEffects.Get<a3w>());
			if (a3w != null)
			{
				num = a3w.Stacks + 1;
			}
			cix cix = base.a8().Zone.ActionManager;
			c5x a_3 = base.a8();
			string a_4 = "CryoShieldShatter" + num.ToString();
			int a_5 = 1;
			double maxValue = double.MaxValue;
			bool a_6 = false;
			bool a_7 = true;
			float? a_8 = dz6.b();
			cix.g9(new a7j(a_3, a_4, a_5, maxValue, a_6, a_7, null, null, null, a_8, false, null), atp.a);
			base.a8().c().a("IceHit");
			base.a8().c().a(Guid.NewGuid().ToString(), "IceOrbSmash", 0.3f, c9z.a, false, false);
			eym.a(base.a8(), (double)aju.bk);
		}
	}

	// Token: 0x06006ECB RID: 28363 RVA: 0x002E8690 File Offset: 0x002E6890
	[dcc("CEA:mD_CIM")]
	private void b(object A_0, b8x A_1)
	{
		if (A_1.e() != null)
		{
			eta service = bpo.GetService<eta>();
			if (service != null)
			{
				cpc a_ = new cpc(A_1.e());
				bey.a(a_, A_1.e(), this);
				service.ao6(a_);
			}
			if (this.aa() is e3q)
			{
				d02 service2 = bpo.GetService<d02>();
				if (service2 != null && service2.ahg())
				{
					int num = cxc.a.GetPrimitivePropertyValue<int>("Player_Missed_Count", new int?(0)).Value;
					if (cxc.a.GetPrimitivePropertyValue<Guid>("Player_Missed_Count_Turn", new Guid?(Guid.Empty)).Value != service2.ahm())
					{
						num = 0;
					}
					num++;
					if (num >= 3)
					{
						cxc.c(eyy.av);
					}
					cxc.a["Player_Missed_Count"] = num;
					cxc.a["Player_Missed_Count_Turn"] = service2.ahm();
				}
			}
			this.a(A_1.e(), null, A_1.c());
			cnk service3 = bpo.GetService<cnk>();
			if (service3.aqu() != null && this.aa().IsInControl && A_1.e().i != null && !string.IsNullOrEmpty(A_1.e().i.b) && this.aa().a(service3.aqu().ac(), A_1.e().i.b) == global::h.a)
			{
				a20.a(base.a8(), A_1.e().i, new CombatSpeakEvent[]
				{
					CombatSpeakEvent.Taunt_Missed
				});
			}
		}
	}

	// Token: 0x06006ECC RID: 28364 RVA: 0x002E8848 File Offset: 0x002E6A48
	[dcc("CEA:mD_VTD")]
	private void b(object A_0, dj7 A_1)
	{
		if (A_1.a() != null && A_1.a().Count > 0)
		{
			Enumerable.Sum<csk>(A_1.a(), new Func<csk, int>(amc.a.a.i));
		}
		if (A_1.e() != null)
		{
			cbh a_ = new cbh(A_1.e(), A_1.a());
			bey.a(a_, A_1.e(), this);
			a7v.a(a_);
			foreach (csk a_2 in A_1.a())
			{
				bmj.a(base.a8(), new dte(a_2, A_1.e().e, A_1.e().r, base.a8().c(e2b.d)));
			}
			this.a(A_1.e(), A_1.a(), A_1.c());
		}
	}

	// Token: 0x06006ECD RID: 28365 RVA: 0x002E8960 File Offset: 0x002E6B60
	[dcc("CEA:mD_VRD")]
	private void a(object A_0, dj7 A_1)
	{
		if (A_1.e() != null)
		{
			etk a_ = new etk(A_1.e(), A_1.a());
			bey.a(a_, A_1.e(), this);
			a7v.a(a_);
			this.a(A_1.e(), A_1.a(), A_1.c());
			if (base.a8().i.b != null)
			{
				base.a8().i.b.a(m7.i, true, false);
			}
		}
	}

	// Token: 0x06006ECE RID: 28366 RVA: 0x002E89E4 File Offset: 0x002E6BE4
	[dcc("CEA:mD_CSR")]
	private void a(object A_0, dsj A_1)
	{
		if (A_1.a() > 0)
		{
			eta service = bpo.GetService<eta>();
			if (service != null)
			{
				dfv a_ = new dfv(new ap9(this.aa()), A_1.a());
				bey.a(a_, this.aa(), this);
				service.ao6(a_);
				bmj.a(base.a8(), new cms(A_1.a(), A_1.b()));
			}
		}
	}

	// Token: 0x06006ECF RID: 28367 RVA: 0x002E8A50 File Offset: 0x002E6C50
	[dcc("CEA:mD_CH")]
	private void a(object A_0, zl A_1)
	{
		e1v a_ = new e1v(new ap9(this.aa()), A_1.b, A_1.c, A_1.a, A_1.d);
		bey.a(a_, this.aa(), this);
		a7v.a(a_);
		bmj.a(base.a8(), new auw(A_1.a, A_1.d));
	}

	// Token: 0x06006ED0 RID: 28368 RVA: 0x002E8AB4 File Offset: 0x002E6CB4
	[dcc("CEA:mD")]
	private void a(object A_0, b8x A_1)
	{
		this.a(A_1.e(), A_1.d());
	}

	// Token: 0x06006ED1 RID: 28369 RVA: 0x002E8ACC File Offset: 0x002E6CCC
	[dcc("CEA:mR")]
	private void a(object A_0, EventArgs A_1)
	{
		this.a3();
		this.m();
		this.n();
		this.f();
		this.e();
		this.av = Guid.NewGuid();
		this.a();
	}

	// Token: 0x06006ED2 RID: 28370 RVA: 0x002E8B08 File Offset: 0x002E6D08
	[dcc("CEA:mG_IU")]
	private void d(object A_0, by0 A_1)
	{
		if (A_1.a() != null && (A_1.a().Definition is c43 || A_1.a().Definition is bke))
		{
			this.s();
		}
	}

	// Token: 0x06006ED3 RID: 28371 RVA: 0x002E8B50 File Offset: 0x002E6D50
	[dcc("CEA:mG_IE")]
	private void c(object A_0, by0 A_1)
	{
		if (A_1.a() != null && (A_1.a().Definition is c43 || A_1.a().Definition is bke))
		{
			this.s();
		}
	}

	// Token: 0x06006ED4 RID: 28372 RVA: 0x002E8B98 File Offset: 0x002E6D98
	[dcc("CEA:mB_IA")]
	private void b(object A_0, by0 A_1)
	{
		e3q e3q = this.aa() as e3q;
		if (e3q != null)
		{
			if (A_1.a() != null)
			{
				x2 x = A_1.a().Definition as x2;
				if (x != null)
				{
					int num = e3q.a(x.a5());
					if (num < x.c())
					{
						e3q.b(x.a5());
						int a_;
						if (e3q.e() == ExperienceSystem.Classic)
						{
							a_ = c2h.c(x.a());
						}
						else
						{
							a_ = x.a();
						}
						this.a(a_, "изучение диковинки: " + A_1.a().Definition.az());
						if (!string.IsNullOrEmpty(x.b()))
						{
							Dictionary<string, object> dictionary = new Dictionary<string, object>();
							dictionary["OddityItem"] = x;
							dictionary["Study"] = num + 1;
							ea5.a(x.b(), base.a8(), base.a8(), dictionary);
						}
					}
					else
					{
						a7v.a(new a1h(new ap9(e3q), string.Format("Вам не удаётся узнать ничего нового от изучения этой диковинки: {0}.", A_1.a().Definition.az()), new Color?(Color.OrangeRed)));
					}
					this.aa().Bag.z5(A_1.a());
				}
			}
			this.a();
		}
	}

	// Token: 0x06006ED5 RID: 28373 RVA: 0x002E8CEC File Offset: 0x002E6EEC
	[dcc("CEA:mB_IR")]
	private void a(object A_0, by0 A_1)
	{
		this.a();
	}

	// Token: 0x06006ED6 RID: 28374 RVA: 0x002E8CF8 File Offset: 0x002E6EF8
	public void v2()
	{
		string text;
		int num;
		if (this.a(out text, out num))
		{
			string str = text;
			int num2;
			num = (num2 = num + 1);
			this.a(str + num2.ToString());
		}
	}

	// Token: 0x06006ED7 RID: 28375 RVA: 0x002E8D30 File Offset: 0x002E6F30
	public void v3()
	{
		string str;
		int num;
		if (this.a(out str, out num))
		{
			this.a(str + Math.Max(1, --num).ToString());
		}
	}

	// Token: 0x06006ED8 RID: 28376 RVA: 0x002E8D6C File Offset: 0x002E6F6C
	public void p9(b0b A_0)
	{
		if (A_0 != null)
		{
			amc aspect = A_0.GetAspect<amc>();
			if (aspect != null)
			{
				aspect.a(this.am());
			}
		}
	}

	// Token: 0x06006ED9 RID: 28377 RVA: 0x002E8D98 File Offset: 0x002E6F98
	public void qa()
	{
		string str;
		int num;
		if (this.a(out str, out num))
		{
			this.a(str + 1.ToString());
		}
	}

	// Token: 0x06006EDA RID: 28378 RVA: 0x002E8DCC File Offset: 0x002E6FCC
	private bool a(out string A_0, out int A_1)
	{
		A_0 = null;
		A_1 = 0;
		Match match = Regex.Match(this.am(), "\\d+");
		if (match != null)
		{
			int.TryParse(match.Value, out A_1);
			A_0 = this.am().Substring(0, match.Index);
			return true;
		}
		return false;
	}

	// Token: 0x06006EDB RID: 28379 RVA: 0x002E8E1C File Offset: 0x002E701C
	private void a()
	{
		if (this.aa() != null)
		{
			this.aa().be = null;
			if (this.aa() is e3q)
			{
				cnk service = bpo.GetService<cnk>();
				if (service != null && service.aqu() != null)
				{
					bool value = service.aqu().r().GetPrimitivePropertyValue<bool>("gp_crp", new bool?(false)).Value;
					float value2 = service.aqu().r().GetPrimitivePropertyValue<float>("gp_crps", new float?(0f)).Value;
					float value3 = service.aqu().r().GetPrimitivePropertyValue<float>("gp_sm", new float?(0f)).Value;
					this.aa().be = new dgj();
					this.aa().be.a(this.aa(), value, value2, value3);
				}
			}
		}
	}

	// Token: 0x06006EDC RID: 28380 RVA: 0x002E8F08 File Offset: 0x002E7108
	public void qw(wq A_0, object A_1)
	{
		if (A_0 != null && !string.IsNullOrEmpty(A_0.TickJob))
		{
			cze cze = dv0.a(A_0.TickJob);
			if (cze != null)
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary["DynamicEffect"] = A_0;
				dictionary["Source"] = A_1;
				a4s a_ = new a4s(cze, null, new ar7(base.a8()), dictionary);
				base.a8().Zone.ActionManager.g9(a_, atp.a);
			}
		}
	}

	// Token: 0x06006EDD RID: 28381 RVA: 0x002E8F88 File Offset: 0x002E7188
	public void qx(bool A_0)
	{
		if (!A_0 && this.aa() != null)
		{
			this.aa().Uid = Guid.NewGuid();
		}
	}

	// Token: 0x04002D18 RID: 11544
	private const int a = 1;

	// Token: 0x04002D19 RID: 11545
	private const float b = 0.15f;

	// Token: 0x04002D1A RID: 11546
	private static readonly float c = 0.001f;

	// Token: 0x04002D1B RID: 11547
	private static readonly double d = 0.38;

	// Token: 0x04002D1C RID: 11548
	[NonSerialized]
	public Dictionary<CharacterState, am5> e;

	// Token: 0x04002D1D RID: 11549
	[NonSerialized]
	public string f;

	// Token: 0x04002D1E RID: 11550
	[NonSerialized]
	public zx g;

	// Token: 0x04002D1F RID: 11551
	[NonSerialized]
	private string h;

	// Token: 0x04002D20 RID: 11552
	[NonSerialized]
	private bool i;

	// Token: 0x04002D21 RID: 11553
	private string j;

	// Token: 0x04002D22 RID: 11554
	private bool k;

	// Token: 0x04002D23 RID: 11555
	private bool l;

	// Token: 0x04002D24 RID: 11556
	private IProvider<efk> m;

	// Token: 0x04002D25 RID: 11557
	private cbg n = new cbg();

	// Token: 0x04002D26 RID: 11558
	private string o = "default";

	// Token: 0x04002D27 RID: 11559
	private bool p;

	// Token: 0x04002D28 RID: 11560
	private bool q;

	// Token: 0x04002D29 RID: 11561
	private bool r;

	// Token: 0x04002D2A RID: 11562
	private bool s;

	// Token: 0x04002D2B RID: 11563
	public bool t;

	// Token: 0x04002D2C RID: 11564
	private bool u;

	// Token: 0x04002D2D RID: 11565
	private bool v;

	// Token: 0x04002D2E RID: 11566
	private List<cze> w = new List<cze>();

	// Token: 0x04002D2F RID: 11567
	private List<cze> x = new List<cze>();

	// Token: 0x04002D30 RID: 11568
	private List<cze> y = new List<cze>();

	// Token: 0x04002D31 RID: 11569
	private List<cze> z = new List<cze>();

	// Token: 0x04002D32 RID: 11570
	private List<cze> aa = new List<cze>();

	// Token: 0x04002D33 RID: 11571
	private List<cze> ab = new List<cze>();

	// Token: 0x04002D34 RID: 11572
	private double ac;

	// Token: 0x04002D35 RID: 11573
	private double ad;

	// Token: 0x04002D36 RID: 11574
	[NonSerialized]
	private amc.f ae;

	// Token: 0x04002D37 RID: 11575
	[NonSerialized]
	private amc.c af;

	// Token: 0x04002D38 RID: 11576
	private int? ag;

	// Token: 0x04002D39 RID: 11577
	private float ah;

	// Token: 0x04002D3A RID: 11578
	private t ai = new t();

	// Token: 0x04002D3B RID: 11579
	private ai5 aj;

	// Token: 0x04002D3C RID: 11580
	[NonSerialized]
	public ai5 ak;

	// Token: 0x04002D3D RID: 11581
	public float al = 1f;

	// Token: 0x04002D3E RID: 11582
	public float am = 1f;

	// Token: 0x04002D3F RID: 11583
	public float? an;

	// Token: 0x04002D40 RID: 11584
	public Color? ao;

	// Token: 0x04002D41 RID: 11585
	public CharacterState? ap;

	// Token: 0x04002D42 RID: 11586
	public int? aq;

	// Token: 0x04002D43 RID: 11587
	public int? ar;

	// Token: 0x04002D44 RID: 11588
	public CharacterState? @as;

	// Token: 0x04002D45 RID: 11589
	public int? at;

	// Token: 0x04002D46 RID: 11590
	private string au;

	// Token: 0x04002D47 RID: 11591
	[NonSerialized]
	private Guid av;

	// Token: 0x04002D48 RID: 11592
	private c1i aw;

	// Token: 0x04002D49 RID: 11593
	private bool ax;

	// Token: 0x04002D4A RID: 11594
	public ae4 ay = new ae4();

	// Token: 0x04002D4B RID: 11595
	[NonSerialized]
	private float az;

	// Token: 0x04002D4C RID: 11596
	[NonSerialized]
	private double a0;

	// Token: 0x04002D4D RID: 11597
	[NonSerialized]
	private double a1;

	// Token: 0x04002D4E RID: 11598
	private string a2;

	// Token: 0x04002D4F RID: 11599
	private string a3;

	// Token: 0x04002D50 RID: 11600
	[NonSerialized]
	private double a4;

	// Token: 0x04002D51 RID: 11601
	[NonSerialized]
	private double a5;

	// Token: 0x04002D52 RID: 11602
	[NonSerialized]
	private int a6;

	// Token: 0x04002D53 RID: 11603
	[NonSerialized]
	private int? a7;

	// Token: 0x0200131E RID: 4894
	private sealed class f : GlobalEventHandler<eoa>
	{
		// Token: 0x06006EE0 RID: 28384 RVA: 0x002E8FC8 File Offset: 0x002E71C8
		public f(amc A_0)
		{
			this.a = A_0;
		}

		// Token: 0x06006EE1 RID: 28385 RVA: 0x002E8FDC File Offset: 0x002E71DC
		public override void cr(eoa A_0)
		{
			if (A_0.e() == this.a.aa().FactionId && A_0.c() != this.a.aa().FactionId)
			{
				h? h = this.a.aa().f(A_0.c());
				if (h == null)
				{
					cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
					if (serviceOrThrow.aqu() != null)
					{
						cky cky = serviceOrThrow.aqu().ac().abu(this.a.aa().FactionId, A_0.c());
						if (cky != null)
						{
							h = new h?(cky.a);
						}
					}
				}
				if (h == null || h.Value > A_0.f())
				{
					this.a.aa().a(A_0.c(), A_0.f());
				}
			}
		}

		// Token: 0x04002D54 RID: 11604
		private amc a;
	}

	// Token: 0x0200131F RID: 4895
	private sealed class c : GlobalEventHandler<ext>
	{
		// Token: 0x06006EE2 RID: 28386 RVA: 0x002E90D4 File Offset: 0x002E72D4
		public c(amc A_0)
		{
			this.a = A_0;
		}

		// Token: 0x06006EE3 RID: 28387 RVA: 0x002E90E4 File Offset: 0x002E72E4
		public override void cr(ext A_0)
		{
			if (this.a.a8().t.b != null && A_0.a != null && A_0.a.ao() != null && A_0.b != null && A_0.b.ao() != null && A_0.a.ao() != this.a && A_0.b.ao().aa().FactionId != this.a.aa().FactionId && this.a.a8().t.b.b(A_0.a.ao(), false))
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null)
				{
					h? h = serviceOrThrow.aqu().ac().abz(this.a.aa().FactionId, A_0.a.ao().aa().FactionId);
					if (h != null)
					{
						h? h2 = this.a.aa().f(A_0.b.ao().aa().FactionId);
						if (h2 == null)
						{
							cky cky = serviceOrThrow.aqu().ac().abu(this.a.aa().FactionId, A_0.b.ao().aa().FactionId);
							if (cky != null)
							{
								h2 = new h?(cky.a);
							}
						}
						if (h2 == null || h2.Value > h.Value)
						{
							this.a.aa().a(A_0.b.ao().aa().FactionId, h.Value);
						}
					}
				}
			}
		}

		// Token: 0x04002D55 RID: 11605
		private amc a;
	}

	// Token: 0x02001321 RID: 4897
	[eiz("CEAa")]
	[Serializable]
	private sealed class d : enp, ISerializable
	{
		// Token: 0x06006EE7 RID: 28391 RVA: 0x002E9370 File Offset: 0x002E7570
		private d(SerializationInfo A_0, StreamingContext A_1)
		{
			if (ell.a() >= 601)
			{
				this.a = A_0.GetDouble("CEAa:P");
			}
		}

		// Token: 0x06006EE8 RID: 28392 RVA: 0x002E9398 File Offset: 0x002E7598
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("CEAa:P", this.a);
		}

		// Token: 0x06006EE9 RID: 28393 RVA: 0x002E93AC File Offset: 0x002E75AC
		public d(double A_0)
		{
			this.a = A_0;
		}

		// Token: 0x06006EEA RID: 28394 RVA: 0x002E93BC File Offset: 0x002E75BC
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (this.a > 0.0)
			{
				bhd.a(A_0, A_1, A_3.a, aph.g, this.a, 3);
			}
		}

		// Token: 0x04002D58 RID: 11608
		private double a;
	}

	// Token: 0x02001322 RID: 4898
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06006EED RID: 28397 RVA: 0x002E9400 File Offset: 0x002E7600
		internal int a(d5o A_0)
		{
			return A_0.StackPortion;
		}

		// Token: 0x06006EEE RID: 28398 RVA: 0x002E9408 File Offset: 0x002E7608
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x06006EEF RID: 28399 RVA: 0x002E9414 File Offset: 0x002E7614
		internal bool o(csk A_0)
		{
			return A_0.DamageType == DamageType.Heat;
		}

		// Token: 0x06006EF0 RID: 28400 RVA: 0x002E9420 File Offset: 0x002E7620
		internal int d(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x06006EF1 RID: 28401 RVA: 0x002E942C File Offset: 0x002E762C
		internal bool e(csk A_0)
		{
			return A_0.DamageType == DamageType.Cold;
		}

		// Token: 0x06006EF2 RID: 28402 RVA: 0x002E9438 File Offset: 0x002E7638
		internal int h(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x06006EF3 RID: 28403 RVA: 0x002E9444 File Offset: 0x002E7644
		internal bool g(csk A_0)
		{
			return A_0.DamageType == DamageType.Energy;
		}

		// Token: 0x06006EF4 RID: 28404 RVA: 0x002E9450 File Offset: 0x002E7650
		internal int r(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x06006EF5 RID: 28405 RVA: 0x002E945C File Offset: 0x002E765C
		internal bool c(csk A_0)
		{
			return A_0.DamageType == DamageType.Electricity;
		}

		// Token: 0x06006EF6 RID: 28406 RVA: 0x002E9468 File Offset: 0x002E7668
		internal int j(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x06006EF7 RID: 28407 RVA: 0x002E9474 File Offset: 0x002E7674
		internal bool l(csk A_0)
		{
			return A_0.DamageType == DamageType.Heat;
		}

		// Token: 0x06006EF8 RID: 28408 RVA: 0x002E9480 File Offset: 0x002E7680
		internal int k(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x06006EF9 RID: 28409 RVA: 0x002E948C File Offset: 0x002E768C
		internal int m(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x06006EFA RID: 28410 RVA: 0x002E9498 File Offset: 0x002E7698
		internal int f(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x06006EFB RID: 28411 RVA: 0x002E94A4 File Offset: 0x002E76A4
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Electricity;
		}

		// Token: 0x06006EFC RID: 28412 RVA: 0x002E94B0 File Offset: 0x002E76B0
		internal int p(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x06006EFD RID: 28413 RVA: 0x002E94BC File Offset: 0x002E76BC
		internal int n(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x06006EFE RID: 28414 RVA: 0x002E94C8 File Offset: 0x002E76C8
		internal int q(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x06006EFF RID: 28415 RVA: 0x002E94D4 File Offset: 0x002E76D4
		internal int i(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002D59 RID: 11609
		public static readonly amc.a a = new amc.a();

		// Token: 0x04002D5A RID: 11610
		public static Func<d5o, int> b;

		// Token: 0x04002D5B RID: 11611
		public static Func<csk, int> c;

		// Token: 0x04002D5C RID: 11612
		public static Func<csk, bool> d;

		// Token: 0x04002D5D RID: 11613
		public static Func<csk, int> e;

		// Token: 0x04002D5E RID: 11614
		public static Func<csk, bool> f;

		// Token: 0x04002D5F RID: 11615
		public static Func<csk, int> g;

		// Token: 0x04002D60 RID: 11616
		public static Func<csk, bool> h;

		// Token: 0x04002D61 RID: 11617
		public static Func<csk, int> i;

		// Token: 0x04002D62 RID: 11618
		public static Func<csk, bool> j;

		// Token: 0x04002D63 RID: 11619
		public static Func<csk, int> k;

		// Token: 0x04002D64 RID: 11620
		public static Func<csk, bool> l;

		// Token: 0x04002D65 RID: 11621
		public static Func<csk, int> m;

		// Token: 0x04002D66 RID: 11622
		public static Func<csk, int> n;

		// Token: 0x04002D67 RID: 11623
		public static Func<csk, int> o;

		// Token: 0x04002D68 RID: 11624
		public static Func<csk, bool> p;

		// Token: 0x04002D69 RID: 11625
		public static Func<csk, int> q;

		// Token: 0x04002D6A RID: 11626
		public static Func<csk, int> r;

		// Token: 0x04002D6B RID: 11627
		public static Func<csk, int> s;

		// Token: 0x04002D6C RID: 11628
		public static Func<csk, int> t;
	}

	// Token: 0x02001323 RID: 4899
	[CompilerGenerated]
	private sealed class b
	{
		// Token: 0x06006F01 RID: 28417 RVA: 0x002E94E8 File Offset: 0x002E76E8
		internal bool a(bsf A_0)
		{
			return A_0.Definition != null && A_0.Definition.Name == this.a;
		}

		// Token: 0x04002D6D RID: 11629
		public string a;
	}

	// Token: 0x02001324 RID: 4900
	[CompilerGenerated]
	private sealed class e
	{
		// Token: 0x06006F03 RID: 28419 RVA: 0x002E9518 File Offset: 0x002E7718
		internal bool a(csk A_0)
		{
			return A_0.DamageType == this.a.DamageType;
		}

		// Token: 0x04002D6E RID: 11630
		public csk a;
	}
}
