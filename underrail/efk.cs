using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Data;
using TimelapseVertigo.Common.Data;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200068F RID: 1679
[eiz("C1")]
[Serializable]
public class efk : ISerializable, IDeserializationCallback
{
	// Token: 0x06002B03 RID: 11011 RVA: 0x000F9760 File Offset: 0x000F7960
	protected efk(SerializationInfo A_0, StreamingContext A_1)
	{
		this.b = A_0.GetString("C1:I");
		this.c = (Guid)A_0.GetValue("C1:U", typeof(Guid));
		this.d = A_0.GetString("C1:N");
		this.f = A_0.GetInt32("C1:L");
		this.g = A_0.GetBoolean("C1:P");
		this.j = A_0.GetBoolean("C1:D");
		this.k = (cbg)A_0.GetValue("C1:SS", typeof(cbg));
		this.l = (Color)A_0.GetValue("C1:C", typeof(Color));
		this.n = (bn2)A_0.GetValue("C1:BA", typeof(bn2));
		this.o = (ech)A_0.GetValue("C1:S", typeof(ech));
		this.p = (an2)A_0.GetValue("C1:F", typeof(an2));
		this.q = (cyr)A_0.GetValue("C1:SA", typeof(cyr));
		this.r = (cyr)A_0.GetValue("C1:SA1", typeof(cyr));
		this.s = (cyr)A_0.GetValue("C1:PA", typeof(cyr));
		this.u = (c40)A_0.GetValue("C1:C1", typeof(c40));
		this.v = (br5)A_0.GetValue("C1:SE", typeof(br5));
		this.w = (aop)A_0.GetValue("C1:A1", typeof(aop));
		this.x = (dcw)A_0.GetValue("C1:B", typeof(dcw));
		this.y = (acd)A_0.GetValue("C1:G", typeof(acd));
		this.ac = A_0.GetSingle("C1:MS");
		this.ad = A_0.GetSingle("C1:BMS");
		this.ae = A_0.GetBoolean("C1:NT");
		this.af = A_0.GetBoolean("C1:T");
		this.ah = A_0.GetBoolean("C1:ND");
		this.ai = A_0.GetBoolean("C1:D1");
		this.aj = A_0.GetInt32("C1:AQS");
		this.ak = (nw)A_0.GetValue("C1:D2", typeof(nw));
		this.al = (dcu)A_0.GetValue("C1:O", typeof(dcu));
		di7.ReadDictionary<WeaponKey, cd1>("C1:DW", ref this.am, A_0);
		di7.ReadDictionary<string, h>("C1:PA1", ref this.an, A_0);
		this.ao = A_0.GetDouble("C1:CTL");
		this.aq = A_0.GetSingle("C1:SR");
		this.ar = A_0.GetSingle("C1:BSR");
		this.@as = A_0.GetString("C1:FI");
		this.at = (c2n)A_0.GetValue("C1:HBM", typeof(c2n));
		this.au = A_0.GetBoolean("C1:PE");
		this.av = A_0.GetSingle("C1:BDM");
		this.aw = A_0.GetSingle("C1:DM");
		this.ax = A_0.GetInt32("C1:D3");
		this.az = (d8o)A_0.GetValue("C1:A2", typeof(d8o));
		this.a0 = (d8o)A_0.GetValue("C1:AB", typeof(d8o));
		this.a1 = (CharacterImmunities)A_0.GetValue("C1:I1", typeof(CharacterImmunities));
		this.a2 = (CharacterImmunities)A_0.GetValue("C1:IB", typeof(CharacterImmunities));
		if (ell.a() >= 0)
		{
			di7.ReadEvent<EventArgs>("C1:R", ref this.bf, A_0);
			di7.ReadEvent<b8x>("C1:D4", ref this.bg, A_0);
			di7.ReadEvent<EventArgs>("C1:CSC", ref this.bh, A_0);
		}
		else
		{
			this.bf = (EventHandler<EventArgs>)A_0.GetValue("C1:R", typeof(EventHandler<EventArgs>));
			this.bg = (EventHandler<b8x>)A_0.GetValue("C1:D4", typeof(EventHandler<b8x>));
		}
		if (ell.a() >= 47)
		{
			this.e = (Gender)A_0.GetValue("C1:G1", typeof(Gender));
		}
		else
		{
			this.e = Gender.Male;
		}
		if (ell.a() >= 132)
		{
			this.ap = A_0.GetDouble("C1:ETT");
		}
		if (ell.a() >= 157)
		{
			this.ay = A_0.GetDouble("C1:SP");
		}
		if (ell.a() >= 178)
		{
			di7.ReadDictionary<CooldownCategory, double>("C1:CMP", ref this.a3, A_0);
			di7.ReadDictionary<CooldownCategory, int>("C1:CMF", ref this.a4, A_0);
		}
		else
		{
			this.a3 = new Dictionary<CooldownCategory, double>();
			this.a4 = new Dictionary<CooldownCategory, int>();
		}
		if (ell.a() >= 192)
		{
			this.a6 = A_0.GetInt32("C1:CC");
		}
		if (ell.a() >= 193)
		{
			this.a7 = (db9)A_0.GetValue("C1:EL", typeof(db9));
		}
		if (ell.a() >= 250)
		{
			this.m = A_0.GetString("C1:P2");
		}
		if (ell.a() >= 252)
		{
			this.a8 = (A_0.GetValue("C1:CA", typeof(PropertyCollection)) as PropertyCollection);
		}
		else
		{
			this.a8 = new PropertyCollection();
		}
		if (ell.a() >= 267)
		{
			di7.ReadDictionary<SpecialCategory, dar>("C1:SCM", ref this.a5, A_0);
		}
		else
		{
			this.a5 = new Dictionary<SpecialCategory, dar>();
		}
		if (ell.a() >= 294)
		{
			this.h = A_0.GetBoolean("C1:E");
		}
		if (ell.a() >= 349)
		{
			this.i = A_0.GetBoolean("C1:E2");
		}
		else
		{
			this.i = this.h;
		}
		if (ell.a() >= 365)
		{
			this.t = (cyr)A_0.GetValue("C1:QC", typeof(cyr));
		}
		else
		{
			this.t = new cyr("Gear");
		}
		if (ell.a() >= 376)
		{
			this.a9 = (A_0.GetValue("C1:VH", typeof(bcx)) as bcx);
		}
		if (ell.a() >= 391)
		{
			di7.ReadDictionary<string, f>("C1:SPC", ref this.ba, A_0);
		}
		else
		{
			this.ba = new Dictionary<string, f>();
		}
		if (ell.a() >= 697)
		{
			this.ag = (A_0.GetValue("C1:TSR", typeof(float?)) as float?);
		}
	}

	// Token: 0x06002B04 RID: 11012 RVA: 0x000F9FD4 File Offset: 0x000F81D4
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("C1:I", this.b);
		info.AddValue("C1:U", this.c);
		info.AddValue("C1:N", this.d);
		info.AddValue("C1:G1", this.e);
		info.AddValue("C1:L", this.f);
		info.AddValue("C1:P", this.g);
		info.AddValue("C1:D", this.j);
		info.AddValue("C1:SS", this.k);
		info.AddValue("C1:C", this.l);
		info.AddValue("C1:P2", this.m);
		info.AddValue("C1:BA", this.n);
		info.AddValue("C1:S", this.o);
		info.AddValue("C1:F", this.p);
		info.AddValue("C1:SA", this.q);
		info.AddValue("C1:SA1", this.r);
		info.AddValue("C1:PA", this.s);
		info.AddValue("C1:C1", this.u);
		info.AddValue("C1:SE", this.v);
		info.AddValue("C1:A1", this.w);
		info.AddValue("C1:B", this.x);
		info.AddValue("C1:G", this.y);
		info.AddValue("C1:MS", this.ac);
		info.AddValue("C1:BMS", this.ad);
		info.AddValue("C1:NT", this.ae);
		info.AddValue("C1:T", this.af);
		info.AddValue("C1:ND", this.ah);
		info.AddValue("C1:D1", this.ai);
		info.AddValue("C1:AQS", this.aj);
		info.AddValue("C1:D2", this.ak);
		info.AddValue("C1:O", this.al);
		di7.WriteDictionary<WeaponKey, cd1>("C1:DW", this.am, info);
		di7.WriteDictionary<string, h>("C1:PA1", this.an, info);
		info.AddValue("C1:CTL", this.ao);
		info.AddValue("C1:SR", this.aq);
		info.AddValue("C1:BSR", this.ar);
		info.AddValue("C1:FI", this.@as);
		info.AddValue("C1:HBM", this.at);
		info.AddValue("C1:PE", this.au);
		info.AddValue("C1:BDM", this.av);
		info.AddValue("C1:DM", this.aw);
		info.AddValue("C1:D3", this.ax);
		info.AddValue("C1:A2", this.az);
		info.AddValue("C1:AB", this.a0);
		info.AddValue("C1:I1", this.a1);
		info.AddValue("C1:IB", this.a2);
		info.AddValue("C1:ETT", this.ap);
		info.AddValue("C1:SP", this.ay);
		di7.WriteEvent<EventArgs>("C1:R", this.bf, info);
		di7.WriteEvent<b8x>("C1:D4", this.bg, info);
		di7.WriteEvent<EventArgs>("C1:CSC", this.bh, info);
		di7.WriteDictionary<CooldownCategory, double>("C1:CMP", this.a3, info);
		di7.WriteDictionary<CooldownCategory, int>("C1:CMF", this.a4, info);
		info.AddValue("C1:CC", this.a6);
		info.AddValue("C1:EL", this.a7);
		info.AddValue("C1:CA", this.a8);
		di7.WriteDictionary<SpecialCategory, dar>("C1:SCM", this.a5, info);
		info.AddValue("C1:E", this.h);
		info.AddValue("C1:E2", this.i);
		info.AddValue("C1:QC", this.t);
		info.AddValue("C1:VH", this.a9);
		di7.WriteDictionary<string, f>("C1:SPC", this.ba, info);
		info.AddValue("C1:TSR", this.ag);
	}

	// Token: 0x17000135 RID: 309
	// (get) Token: 0x06002B05 RID: 11013 RVA: 0x000FA434 File Offset: 0x000F8634
	// (set) Token: 0x06002B06 RID: 11014 RVA: 0x000FA43C File Offset: 0x000F863C
	public string Id
	{
		get
		{
			return this.b;
		}
		set
		{
			this.b = value;
		}
	}

	// Token: 0x17000136 RID: 310
	// (get) Token: 0x06002B07 RID: 11015 RVA: 0x000FA448 File Offset: 0x000F8648
	// (set) Token: 0x06002B08 RID: 11016 RVA: 0x000FA450 File Offset: 0x000F8650
	public Guid Uid
	{
		get
		{
			return this.c;
		}
		set
		{
			this.c = value;
		}
	}

	// Token: 0x17000137 RID: 311
	// (get) Token: 0x06002B09 RID: 11017 RVA: 0x000FA45C File Offset: 0x000F865C
	// (set) Token: 0x06002B0A RID: 11018 RVA: 0x000FA464 File Offset: 0x000F8664
	public string Name
	{
		get
		{
			return this.d;
		}
		set
		{
			this.d = value;
		}
	}

	// Token: 0x17000138 RID: 312
	// (get) Token: 0x06002B0B RID: 11019 RVA: 0x000FA470 File Offset: 0x000F8670
	// (set) Token: 0x06002B0C RID: 11020 RVA: 0x000FA478 File Offset: 0x000F8678
	public Gender Gender
	{
		get
		{
			return this.e;
		}
		set
		{
			this.e = value;
		}
	}

	// Token: 0x17000139 RID: 313
	// (get) Token: 0x06002B0D RID: 11021 RVA: 0x000FA484 File Offset: 0x000F8684
	// (set) Token: 0x06002B0E RID: 11022 RVA: 0x000FA48C File Offset: 0x000F868C
	public int Level
	{
		get
		{
			return this.f;
		}
		set
		{
			this.f = value;
		}
	}

	// Token: 0x1700013A RID: 314
	// (get) Token: 0x06002B0F RID: 11023 RVA: 0x000FA498 File Offset: 0x000F8698
	// (set) Token: 0x06002B10 RID: 11024 RVA: 0x000FA4A0 File Offset: 0x000F86A0
	public string Portrait
	{
		get
		{
			return this.m;
		}
		set
		{
			this.m = value;
		}
	}

	// Token: 0x1700013B RID: 315
	// (get) Token: 0x06002B11 RID: 11025 RVA: 0x000FA4AC File Offset: 0x000F86AC
	// (set) Token: 0x06002B12 RID: 11026 RVA: 0x000FA4B4 File Offset: 0x000F86B4
	public bool Dead
	{
		get
		{
			return this.j;
		}
		set
		{
			this.j = value;
		}
	}

	// Token: 0x1700013C RID: 316
	// (get) Token: 0x06002B13 RID: 11027 RVA: 0x000FA4C0 File Offset: 0x000F86C0
	// (set) Token: 0x06002B14 RID: 11028 RVA: 0x000FA4C8 File Offset: 0x000F86C8
	public bool Passive
	{
		get
		{
			return this.g;
		}
		set
		{
			this.g = value;
		}
	}

	// Token: 0x1700013D RID: 317
	// (get) Token: 0x06002B15 RID: 11029 RVA: 0x000FA4D4 File Offset: 0x000F86D4
	// (set) Token: 0x06002B16 RID: 11030 RVA: 0x000FA4DC File Offset: 0x000F86DC
	public bool EtherealBase
	{
		get
		{
			return this.h;
		}
		set
		{
			this.h = value;
		}
	}

	// Token: 0x1700013E RID: 318
	// (get) Token: 0x06002B17 RID: 11031 RVA: 0x000FA4E8 File Offset: 0x000F86E8
	// (set) Token: 0x06002B18 RID: 11032 RVA: 0x000FA4F0 File Offset: 0x000F86F0
	public bool Ethereal
	{
		get
		{
			return this.i;
		}
		set
		{
			this.i = value;
		}
	}

	// Token: 0x1700013F RID: 319
	// (get) Token: 0x06002B19 RID: 11033 RVA: 0x000FA4FC File Offset: 0x000F86FC
	// (set) Token: 0x06002B1A RID: 11034 RVA: 0x000FA504 File Offset: 0x000F8704
	public Color Color
	{
		get
		{
			return this.l;
		}
		set
		{
			this.l = value;
		}
	}

	// Token: 0x17000140 RID: 320
	// (get) Token: 0x06002B1B RID: 11035 RVA: 0x000FA510 File Offset: 0x000F8710
	public bn2 BaseAbilities
	{
		get
		{
			return this.n;
		}
	}

	// Token: 0x17000141 RID: 321
	// (get) Token: 0x06002B1C RID: 11036 RVA: 0x000FA518 File Offset: 0x000F8718
	public ech Skills
	{
		get
		{
			return this.o;
		}
	}

	// Token: 0x17000142 RID: 322
	// (get) Token: 0x06002B1D RID: 11037 RVA: 0x000FA520 File Offset: 0x000F8720
	public an2 Feats
	{
		get
		{
			return this.p;
		}
	}

	// Token: 0x17000143 RID: 323
	// (get) Token: 0x06002B1E RID: 11038 RVA: 0x000FA528 File Offset: 0x000F8728
	public cyr PsiAbilities
	{
		get
		{
			return this.s;
		}
	}

	// Token: 0x17000144 RID: 324
	// (get) Token: 0x06002B1F RID: 11039 RVA: 0x000FA530 File Offset: 0x000F8730
	public cyr SpecialAbilities
	{
		get
		{
			return this.r;
		}
	}

	// Token: 0x17000145 RID: 325
	// (get) Token: 0x06002B20 RID: 11040 RVA: 0x000FA538 File Offset: 0x000F8738
	public cyr SpecialAttacks
	{
		get
		{
			return this.q;
		}
	}

	// Token: 0x17000146 RID: 326
	// (get) Token: 0x06002B21 RID: 11041 RVA: 0x000FA540 File Offset: 0x000F8740
	public cyr EquippedCapabilities
	{
		get
		{
			return this.t;
		}
	}

	// Token: 0x17000147 RID: 327
	// (get) Token: 0x06002B22 RID: 11042 RVA: 0x000FA548 File Offset: 0x000F8748
	public c40 Cooldowns
	{
		get
		{
			return this.u;
		}
	}

	// Token: 0x17000148 RID: 328
	// (get) Token: 0x06002B23 RID: 11043 RVA: 0x000FA550 File Offset: 0x000F8750
	public br5 StatusEffects
	{
		get
		{
			return this.v;
		}
	}

	// Token: 0x17000149 RID: 329
	// (get) Token: 0x06002B24 RID: 11044 RVA: 0x000FA558 File Offset: 0x000F8758
	public aop Auras
	{
		get
		{
			return this.w;
		}
	}

	// Token: 0x1700014A RID: 330
	// (get) Token: 0x06002B25 RID: 11045 RVA: 0x000FA560 File Offset: 0x000F8760
	public dcw Bag
	{
		get
		{
			return this.x;
		}
	}

	// Token: 0x1700014B RID: 331
	// (get) Token: 0x06002B26 RID: 11046 RVA: 0x000FA568 File Offset: 0x000F8768
	public acd Gear
	{
		get
		{
			return this.y;
		}
	}

	// Token: 0x1700014C RID: 332
	// (get) Token: 0x06002B27 RID: 11047 RVA: 0x000FA570 File Offset: 0x000F8770
	// (set) Token: 0x06002B28 RID: 11048 RVA: 0x000FA578 File Offset: 0x000F8778
	public float MovementSpeed
	{
		get
		{
			return this.ac;
		}
		set
		{
			this.ac = value;
		}
	}

	// Token: 0x1700014D RID: 333
	// (get) Token: 0x06002B29 RID: 11049 RVA: 0x000FA584 File Offset: 0x000F8784
	// (set) Token: 0x06002B2A RID: 11050 RVA: 0x000FA58C File Offset: 0x000F878C
	public int AvailableQuickSlots
	{
		get
		{
			return this.aj;
		}
		set
		{
			this.aj = value;
			if (this.aj < 0)
			{
				this.aj = 0;
				return;
			}
			if (this.aj > aiy.ay)
			{
				this.aj = aiy.ay;
			}
		}
	}

	// Token: 0x1700014E RID: 334
	// (get) Token: 0x06002B2B RID: 11051 RVA: 0x000FA5C4 File Offset: 0x000F87C4
	public nw Defense
	{
		get
		{
			return this.ak;
		}
	}

	// Token: 0x1700014F RID: 335
	// (get) Token: 0x06002B2C RID: 11052 RVA: 0x000FA5CC File Offset: 0x000F87CC
	public dcu Offense
	{
		get
		{
			return this.al;
		}
	}

	// Token: 0x17000150 RID: 336
	// (get) Token: 0x06002B2D RID: 11053 RVA: 0x000FA5D4 File Offset: 0x000F87D4
	public Dictionary<WeaponKey, cd1> DefaultWeapons
	{
		get
		{
			return this.am;
		}
	}

	// Token: 0x17000151 RID: 337
	// (get) Token: 0x06002B2E RID: 11054 RVA: 0x000FA5DC File Offset: 0x000F87DC
	public bool IsInCombat
	{
		get
		{
			return this.ao > 0.0;
		}
	}

	// Token: 0x17000152 RID: 338
	// (get) Token: 0x06002B2F RID: 11055 RVA: 0x000FA5F0 File Offset: 0x000F87F0
	public cbg SpecialStates
	{
		get
		{
			return this.k;
		}
	}

	// Token: 0x17000153 RID: 339
	// (get) Token: 0x06002B30 RID: 11056 RVA: 0x000FA5F8 File Offset: 0x000F87F8
	public bool IsMobile
	{
		get
		{
			return !this.k.b && !this.k.a && !this.k.c && !this.k.k;
		}
	}

	// Token: 0x17000154 RID: 340
	// (get) Token: 0x06002B31 RID: 11057 RVA: 0x000FA648 File Offset: 0x000F8848
	public bool IsInControl
	{
		get
		{
			return !this.k.a && !this.k.c && !this.k.i && !this.k.k;
		}
	}

	// Token: 0x17000155 RID: 341
	// (get) Token: 0x06002B32 RID: 11058 RVA: 0x000FA698 File Offset: 0x000F8898
	public bool IsDisabled
	{
		get
		{
			return this.k.a || this.k.c || this.k.k;
		}
	}

	// Token: 0x17000156 RID: 342
	// (get) Token: 0x06002B33 RID: 11059 RVA: 0x000FA6C8 File Offset: 0x000F88C8
	// (set) Token: 0x06002B34 RID: 11060 RVA: 0x000FA6D0 File Offset: 0x000F88D0
	public float SightRange
	{
		get
		{
			return this.aq;
		}
		set
		{
			this.aq = value;
		}
	}

	// Token: 0x17000157 RID: 343
	// (get) Token: 0x06002B35 RID: 11061 RVA: 0x000FA6DC File Offset: 0x000F88DC
	// (set) Token: 0x06002B36 RID: 11062 RVA: 0x000FA6E4 File Offset: 0x000F88E4
	public string FactionId
	{
		get
		{
			return this.@as;
		}
		set
		{
			this.@as = value;
		}
	}

	// Token: 0x17000158 RID: 344
	// (get) Token: 0x06002B37 RID: 11063 RVA: 0x000FA6F0 File Offset: 0x000F88F0
	public Dictionary<string, h> PersonalAttitudes
	{
		get
		{
			return this.an;
		}
	}

	// Token: 0x17000159 RID: 345
	// (get) Token: 0x06002B38 RID: 11064 RVA: 0x000FA6F8 File Offset: 0x000F88F8
	// (set) Token: 0x06002B39 RID: 11065 RVA: 0x000FA700 File Offset: 0x000F8900
	public c2n HostilityBroadcastMode
	{
		get
		{
			return this.at;
		}
		set
		{
			this.at = value;
		}
	}

	// Token: 0x1700015A RID: 346
	// (get) Token: 0x06002B3A RID: 11066 RVA: 0x000FA70C File Offset: 0x000F890C
	// (set) Token: 0x06002B3B RID: 11067 RVA: 0x000FA714 File Offset: 0x000F8914
	public float BaseMovementSpeed
	{
		get
		{
			return this.ad;
		}
		set
		{
			this.ad = value;
		}
	}

	// Token: 0x1700015B RID: 347
	// (get) Token: 0x06002B3C RID: 11068 RVA: 0x000FA720 File Offset: 0x000F8920
	// (set) Token: 0x06002B3D RID: 11069 RVA: 0x000FA728 File Offset: 0x000F8928
	public float BaseSightRange
	{
		get
		{
			return this.ar;
		}
		set
		{
			this.ar = value;
		}
	}

	// Token: 0x1700015C RID: 348
	// (get) Token: 0x06002B3E RID: 11070 RVA: 0x000FA734 File Offset: 0x000F8934
	// (set) Token: 0x06002B3F RID: 11071 RVA: 0x000FA73C File Offset: 0x000F893C
	public bool PsiEmpathy
	{
		get
		{
			return this.au;
		}
		set
		{
			this.au = value;
		}
	}

	// Token: 0x1700015D RID: 349
	// (get) Token: 0x06002B40 RID: 11072 RVA: 0x000FA748 File Offset: 0x000F8948
	// (set) Token: 0x06002B41 RID: 11073 RVA: 0x000FA750 File Offset: 0x000F8950
	public bool NaturallyTruesighted
	{
		get
		{
			return this.ae;
		}
		set
		{
			this.ae = value;
		}
	}

	// Token: 0x1700015E RID: 350
	// (get) Token: 0x06002B42 RID: 11074 RVA: 0x000FA75C File Offset: 0x000F895C
	// (set) Token: 0x06002B43 RID: 11075 RVA: 0x000FA764 File Offset: 0x000F8964
	public bool Truesighted
	{
		get
		{
			return this.af;
		}
		set
		{
			this.af = value;
		}
	}

	// Token: 0x1700015F RID: 351
	// (get) Token: 0x06002B44 RID: 11076 RVA: 0x000FA770 File Offset: 0x000F8970
	// (set) Token: 0x06002B45 RID: 11077 RVA: 0x000FA778 File Offset: 0x000F8978
	public float? TruesightRange
	{
		get
		{
			return this.ag;
		}
		set
		{
			this.ag = value;
		}
	}

	// Token: 0x17000160 RID: 352
	// (get) Token: 0x06002B46 RID: 11078 RVA: 0x000FA784 File Offset: 0x000F8984
	// (set) Token: 0x06002B47 RID: 11079 RVA: 0x000FA78C File Offset: 0x000F898C
	public bool Darkvision
	{
		get
		{
			return this.ai;
		}
		set
		{
			this.ai = value;
		}
	}

	// Token: 0x17000161 RID: 353
	// (get) Token: 0x06002B48 RID: 11080 RVA: 0x000FA798 File Offset: 0x000F8998
	// (set) Token: 0x06002B49 RID: 11081 RVA: 0x000FA7A0 File Offset: 0x000F89A0
	public bool NaturalDarkvision
	{
		get
		{
			return this.ah;
		}
		set
		{
			this.ah = value;
		}
	}

	// Token: 0x17000162 RID: 354
	// (get) Token: 0x06002B4A RID: 11082 RVA: 0x000FA7AC File Offset: 0x000F89AC
	// (set) Token: 0x06002B4B RID: 11083 RVA: 0x000FA7B4 File Offset: 0x000F89B4
	public int Detection
	{
		get
		{
			return this.ax;
		}
		set
		{
			this.ax = Math.Max(0, value);
		}
	}

	// Token: 0x17000163 RID: 355
	// (get) Token: 0x06002B4C RID: 11084 RVA: 0x000FA7C4 File Offset: 0x000F89C4
	// (set) Token: 0x06002B4D RID: 11085 RVA: 0x000FA7CC File Offset: 0x000F89CC
	public double Suspicion
	{
		get
		{
			return this.ay;
		}
		set
		{
			this.ay = value;
		}
	}

	// Token: 0x17000164 RID: 356
	// (get) Token: 0x06002B4E RID: 11086 RVA: 0x000FA7D8 File Offset: 0x000F89D8
	// (set) Token: 0x06002B4F RID: 11087 RVA: 0x000FA7E0 File Offset: 0x000F89E0
	public float DetectionModifier
	{
		get
		{
			return this.aw;
		}
		set
		{
			this.aw = value;
		}
	}

	// Token: 0x17000165 RID: 357
	// (get) Token: 0x06002B50 RID: 11088 RVA: 0x000FA7EC File Offset: 0x000F89EC
	// (set) Token: 0x06002B51 RID: 11089 RVA: 0x000FA7F4 File Offset: 0x000F89F4
	public float BaseDetectionModifier
	{
		get
		{
			return this.av;
		}
		set
		{
			this.av = value;
		}
	}

	// Token: 0x17000166 RID: 358
	// (get) Token: 0x06002B52 RID: 11090 RVA: 0x000FA800 File Offset: 0x000F8A00
	// (set) Token: 0x06002B53 RID: 11091 RVA: 0x000FA808 File Offset: 0x000F8A08
	public d8o Attributes
	{
		get
		{
			return this.az;
		}
		set
		{
			this.az = value;
		}
	}

	// Token: 0x17000167 RID: 359
	// (get) Token: 0x06002B54 RID: 11092 RVA: 0x000FA814 File Offset: 0x000F8A14
	// (set) Token: 0x06002B55 RID: 11093 RVA: 0x000FA81C File Offset: 0x000F8A1C
	public d8o AttributesBase
	{
		get
		{
			return this.a0;
		}
		set
		{
			this.a0 = value;
		}
	}

	// Token: 0x17000168 RID: 360
	// (get) Token: 0x06002B56 RID: 11094 RVA: 0x000FA828 File Offset: 0x000F8A28
	// (set) Token: 0x06002B57 RID: 11095 RVA: 0x000FA830 File Offset: 0x000F8A30
	public CharacterImmunities Immunities
	{
		get
		{
			return this.a1;
		}
		set
		{
			this.a1 = value;
		}
	}

	// Token: 0x17000169 RID: 361
	// (get) Token: 0x06002B58 RID: 11096 RVA: 0x000FA83C File Offset: 0x000F8A3C
	// (set) Token: 0x06002B59 RID: 11097 RVA: 0x000FA844 File Offset: 0x000F8A44
	public CharacterImmunities ImmunitiesBase
	{
		get
		{
			return this.a2;
		}
		set
		{
			this.a2 = value;
		}
	}

	// Token: 0x1700016A RID: 362
	// (get) Token: 0x06002B5A RID: 11098 RVA: 0x000FA850 File Offset: 0x000F8A50
	public bool ImmuneToCriticalHits
	{
		get
		{
			return this.g || this.a(CharacterImmunities.CriticalHits);
		}
	}

	// Token: 0x1700016B RID: 363
	// (get) Token: 0x06002B5B RID: 11099 RVA: 0x000FA86C File Offset: 0x000F8A6C
	public Dictionary<CooldownCategory, double> CooldownModifiersPercentage
	{
		get
		{
			return this.a3;
		}
	}

	// Token: 0x1700016C RID: 364
	// (get) Token: 0x06002B5C RID: 11100 RVA: 0x000FA874 File Offset: 0x000F8A74
	public Dictionary<CooldownCategory, int> CooldownModifiersFlat
	{
		get
		{
			return this.a4;
		}
	}

	// Token: 0x1700016D RID: 365
	// (get) Token: 0x06002B5D RID: 11101 RVA: 0x000FA87C File Offset: 0x000F8A7C
	public Dictionary<SpecialCategory, dar> SpecialCategoryModifiers
	{
		get
		{
			return this.a5;
		}
	}

	// Token: 0x1700016E RID: 366
	// (get) Token: 0x06002B5E RID: 11102 RVA: 0x000FA884 File Offset: 0x000F8A84
	// (set) Token: 0x06002B5F RID: 11103 RVA: 0x000FA88C File Offset: 0x000F8A8C
	public int CarryCapacity
	{
		get
		{
			return this.a6;
		}
		set
		{
			this.a6 = value;
		}
	}

	// Token: 0x1700016F RID: 367
	// (get) Token: 0x06002B60 RID: 11104 RVA: 0x000FA898 File Offset: 0x000F8A98
	public db9 EncumbranceLevel
	{
		get
		{
			return this.a7;
		}
	}

	// Token: 0x17000170 RID: 368
	// (get) Token: 0x06002B61 RID: 11105 RVA: 0x000FA8A0 File Offset: 0x000F8AA0
	// (set) Token: 0x06002B62 RID: 11106 RVA: 0x000FA8A8 File Offset: 0x000F8AA8
	public PropertyCollection CustomProperties
	{
		get
		{
			return this.a8;
		}
		set
		{
			this.a8 = value;
		}
	}

	// Token: 0x17000171 RID: 369
	// (get) Token: 0x06002B63 RID: 11107 RVA: 0x000FA8B4 File Offset: 0x000F8AB4
	// (set) Token: 0x06002B64 RID: 11108 RVA: 0x000FA8BC File Offset: 0x000F8ABC
	public bcx Vehicle
	{
		get
		{
			return this.a9;
		}
		set
		{
			this.a9 = value;
		}
	}

	// Token: 0x17000172 RID: 370
	// (get) Token: 0x06002B65 RID: 11109 RVA: 0x000FA8C8 File Offset: 0x000F8AC8
	public Dictionary<string, f> Specializations
	{
		get
		{
			return this.ba;
		}
	}

	// Token: 0x06002B66 RID: 11110 RVA: 0x000FA8D4 File Offset: 0x000F8AD4
	[CompilerGenerated]
	public void a(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.bf;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.bf, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06002B67 RID: 11111 RVA: 0x000FA90C File Offset: 0x000F8B0C
	[CompilerGenerated]
	public void c(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.bf;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.bf, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06002B68 RID: 11112 RVA: 0x000FA944 File Offset: 0x000F8B44
	[CompilerGenerated]
	public void a(EventHandler<b8x> A_0)
	{
		EventHandler<b8x> eventHandler = this.bg;
		EventHandler<b8x> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b8x> value = (EventHandler<b8x>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b8x>>(ref this.bg, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06002B69 RID: 11113 RVA: 0x000FA97C File Offset: 0x000F8B7C
	[CompilerGenerated]
	public void b(EventHandler<b8x> A_0)
	{
		EventHandler<b8x> eventHandler = this.bg;
		EventHandler<b8x> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b8x> value = (EventHandler<b8x>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b8x>>(ref this.bg, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06002B6A RID: 11114 RVA: 0x000FA9B4 File Offset: 0x000F8BB4
	[CompilerGenerated]
	public void b(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.bh;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.bh, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06002B6B RID: 11115 RVA: 0x000FA9EC File Offset: 0x000F8BEC
	[CompilerGenerated]
	public void d(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.bh;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.bh, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06002B6C RID: 11116 RVA: 0x000FAA24 File Offset: 0x000F8C24
	public efk()
	{
		this.i();
	}

	// Token: 0x06002B6D RID: 11117 RVA: 0x000FAB3C File Offset: 0x000F8D3C
	public void ak()
	{
		if (!this.a)
		{
			this.f();
			this.a = true;
		}
	}

	// Token: 0x06002B6E RID: 11118 RVA: 0x000FAB58 File Offset: 0x000F8D58
	public void bl()
	{
		c91 a_ = dgk.Get<c91>();
		if (!this.q.c(a_))
		{
			this.q.b(a_);
		}
		this.ak();
		this.h();
		this.ak.n();
		this.al.o();
		ll ll = new ll(this);
		SortedList<d3e, RequirementRestrictedElementContainer<d3e>> sortedList = new SortedList<d3e, RequirementRestrictedElementContainer<d3e>>();
		SortedList<d3e, RequirementRestrictedElementContainer<d3e>> sortedList2 = new SortedList<d3e, RequirementRestrictedElementContainer<d3e>>();
		SortedList<d3e, RequirementRestrictedElementContainer<d3e>> sortedList3 = new SortedList<d3e, RequirementRestrictedElementContainer<d3e>>();
		SortedList<d3e, RequirementRestrictedElementContainer<d3e>> sortedList4 = new SortedList<d3e, RequirementRestrictedElementContainer<d3e>>();
		SortedList<d3e, RequirementRestrictedElementContainer<d3e>> sortedList5 = new SortedList<d3e, RequirementRestrictedElementContainer<d3e>>();
		List<RequirementRestrictedElementContainer<d3e>> list = new List<RequirementRestrictedElementContainer<d3e>>();
		foreach (ai8 ai in this.p)
		{
			List<d3e> list2 = ai.cy(this);
			if (list2 != null && list2.Count > 0)
			{
				foreach (d3e a_2 in list2)
				{
					list.Add(new RequirementRestrictedElementContainer<d3e>(a_2, null, null));
				}
			}
		}
		foreach (RequirementRestrictedElementContainer<d3e> requirementRestrictedElementContainer in Enumerable.Union<RequirementRestrictedElementContainer<d3e>>(this.z, list))
		{
			d3e d3e = requirementRestrictedElementContainer.c;
			asx asx = d3e as asx;
			if (d3e is awe)
			{
				sortedList.Add(d3e, requirementRestrictedElementContainer);
			}
			else if (d3e is bdr)
			{
				sortedList2.Add(d3e, requirementRestrictedElementContainer);
			}
			else if (d3e is em0)
			{
				sortedList3.Add(d3e, requirementRestrictedElementContainer);
			}
			else if (asx != null && asx.vj() == ni.b)
			{
				sortedList5.Add(d3e, requirementRestrictedElementContainer);
			}
			else
			{
				sortedList4.Add(d3e, requirementRestrictedElementContainer);
			}
		}
		foreach (RequirementRestrictedElementContainer<d3e> a_3 in sortedList.Values)
		{
			this.a(a_3, ll);
		}
		this.n.a(ll, sortedList2.Values);
		this.k();
		this.o.a(ll, sortedList3.Values);
		this.j();
		this.g();
		this.ak.a(ll, sortedList5);
		this.al.r();
		this.e();
		this.d();
		this.c();
		foreach (RequirementRestrictedElementContainer<d3e> a_4 in sortedList4.Values)
		{
			this.a(a_4, ll);
		}
		this.b();
		this.ak.r();
		this.t.b();
		foreach (coh coh in this.Gear.i())
		{
			a06 a = coh as a06;
			if (a != null && a.fu() != null && a.fu().@as().Count > 0)
			{
				foreach (aia aia in a.fu().@as())
				{
					if (aia.Value != null)
					{
						this.t.b(aia.Value);
					}
				}
			}
		}
		if (this.a9 != null)
		{
			foreach (aia aia2 in this.a9.ai())
			{
				if (aia2.Value != null)
				{
					this.t.b(aia2.Value);
				}
			}
			this.az |= this.a9.s();
		}
		this.l();
		if (this.bf != null)
		{
			this.bf(this, new EventArgs());
		}
	}

	// Token: 0x06002B6F RID: 11119 RVA: 0x000FB014 File Offset: 0x000F9214
	internal void a(RequirementRestrictedElementContainer<d3e> A_0, ll A_1)
	{
		if (A_0.a(this))
		{
			A_0.c.a(A_1);
			A_0.d = new bool?(true);
			cdh cdh = A_0.c as cdh;
			if (cdh != null)
			{
				this.a(cdh);
				return;
			}
		}
		else
		{
			A_0.d = new bool?(false);
		}
	}

	// Token: 0x06002B70 RID: 11120 RVA: 0x000FB06C File Offset: 0x000F926C
	private void l()
	{
		if (this.a9 != null)
		{
			this.ac = (float)this.a9.m();
			if (this.a9.g() > 0.0)
			{
				int num = c3w.i;
				if (this.StatusEffects.a(ckc.a))
				{
					num = Convert.ToInt32((double)num * (1.0 + cd8.c));
				}
				this.al.x = (int)Math.Min((double)num, (double)aiy.h * this.a9.m());
				return;
			}
			this.al.x = 0;
		}
	}

	// Token: 0x06002B71 RID: 11121 RVA: 0x000FB114 File Offset: 0x000F9314
	private void k()
	{
		this.a6 = aiy.ck + aiy.cl * this.n.Strength;
		if (this is e3q)
		{
			this.a6 = Convert.ToInt32((float)this.a6 * euf.b().CarryCapacityMod);
		}
		this.bc = this.x.a();
		foreach (coh coh in this.y.i())
		{
			this.bc += coh.Weight;
		}
		this.bc = (double)((int)this.bc);
	}

	// Token: 0x06002B72 RID: 11122 RVA: 0x000FB1E4 File Offset: 0x000F93E4
	private void j()
	{
		if (this.bc <= (double)this.a6)
		{
			this.a7 = db9.a;
			return;
		}
		if (this.bc > (double)this.a6 * aiy.cn)
		{
			this.a7 = db9.d;
			return;
		}
		if (this.bc > (double)this.a6 * aiy.cm)
		{
			this.a7 = db9.c;
			return;
		}
		this.a7 = db9.b;
	}

	// Token: 0x06002B73 RID: 11123 RVA: 0x000FB254 File Offset: 0x000F9454
	public void a(b4t A_0, double A_1, bool A_2)
	{
		if (!A_2)
		{
			if (this.ao > 0.0)
			{
				this.ao -= A_1;
				if (this.ao <= 0.0 && this.bh != null)
				{
					this.bh(this, new EventArgs());
				}
			}
			this.u.a(A_1);
			if ((this.ap += A_1) >= (double)d0u.b)
			{
				this.ap -= (double)d0u.b;
				this.a(A_0);
			}
		}
		this.w.a(A_1);
		this.v.a(A_1, A_2);
		this.ak.a(A_1, A_2);
		this.al.a(A_1, A_2);
		h value;
		if (this.an.TryGetValue(asp.a, out value))
		{
			this.an[asp.c] = value;
			return;
		}
		this.an.Remove(asp.c);
	}

	// Token: 0x06002B74 RID: 11124 RVA: 0x000FB368 File Offset: 0x000F9568
	public void b(b4t A_0)
	{
		this.ap = 0.0;
		if (this.ao > 0.0)
		{
			this.ao -= (double)d0u.b;
			if (this.ao <= 0.0 && this.bh != null)
			{
				this.bh(this, new EventArgs());
			}
		}
		this.a(A_0);
		this.u.c();
		this.w.b();
		this.v.b();
		this.al.z();
		this.ak.t();
		this.bl();
	}

	// Token: 0x06002B75 RID: 11125 RVA: 0x000FB420 File Offset: 0x000F9620
	public h a(oj A_0, string A_1)
	{
		if (A_1 != null && this.FactionId != null)
		{
			if (this.an.ContainsKey(A_1))
			{
				return this.an[A_1];
			}
			if (A_0 != null)
			{
				cky cky = A_0.abu(this.FactionId, A_1);
				if (cky != null)
				{
					return cky.a;
				}
			}
		}
		return global::h.c;
	}

	// Token: 0x06002B76 RID: 11126 RVA: 0x000FB480 File Offset: 0x000F9680
	public void c(string A_0)
	{
		this.an.Remove(A_0);
	}

	// Token: 0x06002B77 RID: 11127 RVA: 0x000FB490 File Offset: 0x000F9690
	public void a(string A_0, h A_1)
	{
		this.an[A_0] = A_1;
	}

	// Token: 0x06002B78 RID: 11128 RVA: 0x000FB4A0 File Offset: 0x000F96A0
	public h? f(string A_0)
	{
		if (this.an.ContainsKey(A_0))
		{
			return new h?(this.an[A_0]);
		}
		return null;
	}

	// Token: 0x06002B79 RID: 11129 RVA: 0x000FB4DC File Offset: 0x000F96DC
	public void a(oj A_0, string A_1, string A_2, object A_3, bool A_4 = true)
	{
		if (A_4)
		{
			bool flag = this.IsInCombat;
			this.ao = 2000.0;
			if (flag && this.bh != null)
			{
				this.bh(this, new EventArgs());
			}
		}
		if (string.IsNullOrEmpty(A_2) || A_2 != this.Id)
		{
			this.a(A_1, global::h.a);
			if (A_0 != null && !string.IsNullOrEmpty(A_1))
			{
				A_0.aby(this.FactionId, A_1, this.at, A_3);
			}
		}
	}

	// Token: 0x06002B7A RID: 11130 RVA: 0x000FB570 File Offset: 0x000F9770
	public void a(cwt A_0, cru A_1, bool A_2 = false)
	{
		this.j = true;
		this.ak.q().zn(Math.Max(1f, this.ak.q().zm()));
		if (this.bg != null)
		{
			this.bg(this, new b8x(A_0, A_1, A_2));
		}
	}

	// Token: 0x06002B7B RID: 11131 RVA: 0x000FB5D0 File Offset: 0x000F97D0
	public coh a(string A_0, int A_1, bool A_2)
	{
		coh coh = null;
		foreach (d5o d5o in this.b(A_0, A_1, true))
		{
			if (coh == null)
			{
				coh = d5o.Item.fy();
				coh.Stacks = 0;
			}
			coh.Stacks += Math.Min(d5o.StackPortion, d5o.Item.Stacks);
			if (d5o.StackPortion < d5o.Item.Stacks)
			{
				d5o.Item.Stacks -= d5o.StackPortion;
			}
			else
			{
				this.a(d5o.Item);
			}
		}
		return coh;
	}

	// Token: 0x06002B7C RID: 11132 RVA: 0x000FB6A8 File Offset: 0x000F98A8
	public bool a(coh A_0)
	{
		return this.x.z5(A_0) || this.y.c(A_0);
	}

	// Token: 0x06002B7D RID: 11133 RVA: 0x000FB6CC File Offset: 0x000F98CC
	public bool d(a06 A_0)
	{
		if (A_0 is cd1)
		{
			return this.al.u() == A_0;
		}
		return A_0 != null && this.y.b(A_0.Id) != null;
	}

	// Token: 0x06002B7E RID: 11134 RVA: 0x000FB708 File Offset: 0x000F9908
	public coh c(Guid A_0)
	{
		coh coh = this.x.a(A_0);
		if (coh != null)
		{
			this.x.z5(coh);
			return coh;
		}
		return this.y.a(A_0);
	}

	// Token: 0x06002B7F RID: 11135 RVA: 0x000FB748 File Offset: 0x000F9948
	public coh a(Guid A_0)
	{
		coh coh = this.x.a(A_0);
		if (coh == null)
		{
			coh = this.y.b(A_0);
		}
		return coh;
	}

	// Token: 0x06002B80 RID: 11136 RVA: 0x000FB778 File Offset: 0x000F9978
	public coh a(string A_0, bool A_1)
	{
		coh coh = Enumerable.FirstOrDefault<coh>(this.x.b(A_0));
		if (coh == null && A_1)
		{
			coh = this.y.b(A_0);
		}
		return coh;
	}

	// Token: 0x06002B81 RID: 11137 RVA: 0x000FB7B0 File Offset: 0x000F99B0
	public List<d5o> b(string A_0, int A_1, bool A_2)
	{
		IEnumerable<coh> enumerable = this.x.z2();
		if (A_2)
		{
			enumerable = Enumerable.Union<coh>(enumerable, this.y.i());
		}
		return enumerable.a(A_0, A_1);
	}

	// Token: 0x06002B82 RID: 11138 RVA: 0x000FB7EC File Offset: 0x000F99EC
	public bool c(d8o A_0)
	{
		return (this.az & A_0) == A_0;
	}

	// Token: 0x06002B83 RID: 11139 RVA: 0x000FB7FC File Offset: 0x000F99FC
	public bool b(d8o A_0)
	{
		return (this.az & A_0) > d8o.a;
	}

	// Token: 0x06002B84 RID: 11140 RVA: 0x000FB80C File Offset: 0x000F9A0C
	public bool a(CharacterImmunities A_0)
	{
		return (this.a1 & A_0) == A_0;
	}

	// Token: 0x06002B85 RID: 11141 RVA: 0x000FB81C File Offset: 0x000F9A1C
	public bool d(CharacterImmunities A_0)
	{
		return (this.a1 & A_0) > CharacterImmunities.None;
	}

	// Token: 0x06002B86 RID: 11142 RVA: 0x000FB82C File Offset: 0x000F9A2C
	public void c(a06 A_0)
	{
		if (A_0 != null)
		{
			this.a(A_0);
			if (this.d(A_0))
			{
				this.b(A_0);
			}
		}
	}

	// Token: 0x06002B87 RID: 11143 RVA: 0x000FB854 File Offset: 0x000F9A54
	public void a(bool A_0)
	{
		Dictionary<string, coh> value = this.Gear.a(A_0);
		this.CustomProperties["StoredGear"] = value;
	}

	// Token: 0x06002B88 RID: 11144 RVA: 0x000FB880 File Offset: 0x000F9A80
	public void az()
	{
		Dictionary<string, coh> classPropertyValue = this.CustomProperties.GetClassPropertyValue<Dictionary<string, coh>>("StoredGear");
		if (classPropertyValue != null)
		{
			this.Gear.a(classPropertyValue);
		}
	}

	// Token: 0x06002B89 RID: 11145 RVA: 0x000FB8B0 File Offset: 0x000F9AB0
	public void s()
	{
		if (this is e3q && this.ao > 500.0)
		{
			this.ao = 500.0;
		}
	}

	// Token: 0x06002B8A RID: 11146 RVA: 0x000FB8E0 File Offset: 0x000F9AE0
	public void j(int A_0)
	{
		if (this.StatusEffects.a(csc.a))
		{
			this.Defense.q().zp(Math.Max(1f, this.Defense.q().zo() - cpn.a(new eoj(this, null, null), A_0)));
			return;
		}
		IBoundVariable<float> boundVariable = this.Offense.aa();
		boundVariable.zp(boundVariable.zo() - (float)A_0);
	}

	// Token: 0x06002B8B RID: 11147 RVA: 0x000FB958 File Offset: 0x000F9B58
	public bool i(int A_0)
	{
		if (this.StatusEffects.a(csc.a))
		{
			return (float)((int)this.Defense.q().zo()) > cpn.a(new eoj(this, null, null), A_0);
		}
		return this.Offense.aa().zo() >= (float)A_0;
	}

	// Token: 0x06002B8C RID: 11148 RVA: 0x000FB9B4 File Offset: 0x000F9BB4
	public int a(apq A_0, bool A_1 = true)
	{
		if (A_0 != null)
		{
			f f;
			this.ba.TryGetValue(A_0.e4(), out f);
			if (f != null)
			{
				if (A_1)
				{
					return f.ModifiedValue;
				}
				return f.Value;
			}
		}
		return 0;
	}

	// Token: 0x06002B8D RID: 11149 RVA: 0x000FB9F8 File Offset: 0x000F9BF8
	public int GetSpecializationValue<T>(bool modified = true) where T : apq
	{
		apq specialization = ac8.GetSpecialization<T>();
		return this.a(specialization, modified);
	}

	// Token: 0x06002B8E RID: 11150 RVA: 0x000FBA14 File Offset: 0x000F9C14
	public T GetMicrofeat<T>() where T : cdh
	{
		return Enumerable.FirstOrDefault<T>(this.GetMicrofeats<T>());
	}

	// Token: 0x06002B8F RID: 11151 RVA: 0x000FBA24 File Offset: 0x000F9C24
	public List<T> GetMicrofeats<T>() where T : cdh
	{
		return Enumerable.ToList<T>(Enumerable.OfType<T>(this.aa));
	}

	// Token: 0x06002B90 RID: 11152 RVA: 0x000FBA38 File Offset: 0x000F9C38
	public bool? a(d3e A_0)
	{
		foreach (RequirementRestrictedElementContainer<d3e> requirementRestrictedElementContainer in this.z)
		{
			if (requirementRestrictedElementContainer.c == A_0)
			{
				return requirementRestrictedElementContainer.d;
			}
		}
		return null;
	}

	// Token: 0x06002B91 RID: 11153 RVA: 0x000FBAB0 File Offset: 0x000F9CB0
	public bool a(wq A_0)
	{
		foreach (RequirementRestrictedElementContainer<wq> requirementRestrictedElementContainer in this.ab)
		{
			if (requirementRestrictedElementContainer.c == A_0)
			{
				if (requirementRestrictedElementContainer.d == null)
				{
					return requirementRestrictedElementContainer.a(this);
				}
				return requirementRestrictedElementContainer.d.GetValueOrDefault();
			}
		}
		return true;
	}

	// Token: 0x06002B92 RID: 11154 RVA: 0x000FBB40 File Offset: 0x000F9D40
	internal void a(IEnumerable<d3e> A_0)
	{
		czh.a(A_0, "effects");
		foreach (d3e d3e in A_0)
		{
			foreach (RequirementRestrictedElementContainer<d3e> requirementRestrictedElementContainer in this.z)
			{
				if (requirementRestrictedElementContainer.c == d3e)
				{
					this.z.Remove(requirementRestrictedElementContainer);
					break;
				}
			}
		}
	}

	// Token: 0x06002B93 RID: 11155 RVA: 0x000FBBF4 File Offset: 0x000F9DF4
	internal void a(IEnumerable<wq> A_0)
	{
		czh.a(A_0, "effects");
		foreach (wq wq in A_0)
		{
			foreach (RequirementRestrictedElementContainer<wq> requirementRestrictedElementContainer in this.ab)
			{
				if (requirementRestrictedElementContainer.c == wq)
				{
					this.ab.Remove(requirementRestrictedElementContainer);
					break;
				}
			}
		}
	}

	// Token: 0x06002B94 RID: 11156 RVA: 0x000FBCA8 File Offset: 0x000F9EA8
	internal void a(IEnumerable<d3e> A_0, object A_1 = null, c6m A_2 = null)
	{
		czh.a(A_0, "effects");
		foreach (d3e a_ in A_0)
		{
			RequirementRestrictedElementContainer<d3e> item = new RequirementRestrictedElementContainer<d3e>(a_, A_1, A_2);
			this.z.Add(item);
		}
	}

	// Token: 0x06002B95 RID: 11157 RVA: 0x000FBD10 File Offset: 0x000F9F10
	internal void a(IEnumerable<wq> A_0, object A_1 = null, c6m A_2 = null)
	{
		czh.a(A_0, "effects");
		foreach (wq a_ in A_0)
		{
			RequirementRestrictedElementContainer<wq> item = new RequirementRestrictedElementContainer<wq>(a_, A_1, A_2);
			this.ab.Add(item);
		}
	}

	// Token: 0x06002B96 RID: 11158 RVA: 0x000FBD78 File Offset: 0x000F9F78
	private void i()
	{
		if (this.c == Guid.Empty)
		{
			this.c = Guid.NewGuid();
		}
		this.n = new bn2(this);
		this.o = new axp(this);
		this.p = new esx(this);
		this.u = new c40();
		this.v = new br5(this);
		this.w = new aop(this);
		this.ak = new nw(this);
		this.al = new dcu(this);
		this.g();
		this.y.d(new EventHandler<by0>(this.c));
		this.y.b(new EventHandler<by0>(this.d));
		this.x.zw(new EventHandler<by0>(this.a));
		this.x.zy(new EventHandler<by0>(this.b));
	}

	// Token: 0x06002B97 RID: 11159 RVA: 0x000FBE68 File Offset: 0x000FA068
	private void h()
	{
		this.aw = this.av;
		this.aq = this.ar;
		this.af = this.ae;
		this.ai = this.ah;
		this.k.a();
		this.aj = aiy.ax;
		this.az = this.a0;
		this.a1 = this.a2;
		if (this.a9 != null)
		{
			this.a1 |= CharacterImmunities.Root;
		}
		this.i = this.h;
		this.bb = eom.a;
		foreach (object obj in Enum.GetValues(typeof(CooldownCategory)))
		{
			CooldownCategory key = (CooldownCategory)obj;
			this.a3[key] = 1.0;
			this.a4[key] = 0;
		}
		foreach (object obj2 in Enum.GetValues(typeof(SpecialCategory)))
		{
			SpecialCategory key2 = (SpecialCategory)obj2;
			this.a5[key2] = new dar();
		}
		foreach (KeyValuePair<string, f> keyValuePair in Enumerable.ToList<KeyValuePair<string, f>>(this.ba))
		{
			keyValuePair.Value.b();
			if (keyValuePair.Value.ModifiedValue == 0)
			{
				this.ba.Remove(keyValuePair.Key);
			}
		}
		this.aa = new List<cdh>();
	}

	// Token: 0x06002B98 RID: 11160 RVA: 0x000FC068 File Offset: 0x000FA268
	private void g()
	{
		Dictionary<WeaponKey, cd1> dictionary = this.a();
		this.am[WeaponKey.Primary] = dictionary[WeaponKey.Primary];
		this.am[WeaponKey.Secondary] = dictionary[WeaponKey.Secondary];
	}

	// Token: 0x06002B99 RID: 11161 RVA: 0x000FC0A4 File Offset: 0x000FA2A4
	private void f()
	{
		this.z = new List<RequirementRestrictedElementContainer<d3e>>();
		this.ab = new List<RequirementRestrictedElementContainer<wq>>();
		foreach (els els in this.v.d())
		{
			foreach (d3e a_ in els.StaticEffects)
			{
				this.z.Add(new RequirementRestrictedElementContainer<d3e>(a_, null, null));
			}
		}
		this.b(this.y.l().Item);
		this.b(this.y.e().Item);
		this.b(this.y.f().Item);
		this.b(this.y.g().Item);
		this.b(this.y.h().Item);
		this.b(this.al.u());
	}

	// Token: 0x06002B9A RID: 11162 RVA: 0x000FC1E4 File Offset: 0x000FA3E4
	private void b(a06 A_0)
	{
		if (A_0 != null && A_0.fu() != null)
		{
			ke.a(this, A_0);
			this.a(A_0.fu().ar(), A_0, A_0.fu());
			this.a(A_0.fu().ao(), A_0, A_0.fu());
		}
	}

	// Token: 0x06002B9B RID: 11163 RVA: 0x000FC23C File Offset: 0x000FA43C
	private void a(a06 A_0)
	{
		if (A_0 != null && A_0.fu() != null)
		{
			this.a(A_0.fu().ar());
			this.a(A_0.fu().ao());
		}
	}

	// Token: 0x06002B9C RID: 11164 RVA: 0x000FC27C File Offset: 0x000FA47C
	private void e()
	{
		this.ac = this.ad;
		if (this.a7 == db9.b)
		{
			this.ac *= 0.5f;
			return;
		}
		if (this.a7 == db9.c)
		{
			this.ac *= 0.3f;
		}
	}

	// Token: 0x06002B9D RID: 11165 RVA: 0x000FC2D4 File Offset: 0x000FA4D4
	private void d()
	{
		this.ax = (int)(this.aw * (float)c2h.a(this.BaseAbilities.Perception, c2h.d(this)));
		if (!(this is e3q))
		{
			this.ax += aiy.c;
		}
	}

	// Token: 0x06002B9E RID: 11166 RVA: 0x000FC324 File Offset: 0x000FA524
	private void c()
	{
	}

	// Token: 0x06002B9F RID: 11167 RVA: 0x000FC32C File Offset: 0x000FA52C
	private void b()
	{
		bool value = this.CustomProperties.GetPrimitivePropertyValue<bool>(ddm.f, new bool?(false)).Value;
		foreach (coh a_ in this.y.a(this.aj))
		{
			this.x.z3(a_, false);
		}
		this.y.g().Enabled = !value;
		this.y.l().Enabled = !value;
		this.y.e().Enabled = !value;
		this.y.f().Enabled = !value;
		this.y.h().Enabled = !value;
		this.y.j()[WeaponKey.Primary].Enabled = !value;
		this.y.j()[WeaponKey.Secondary].Enabled = !value;
		for (int i = 0; i < this.y.d().Length; i++)
		{
			this.y.d()[i].Enabled = (i < this.aj && !value);
		}
	}

	// Token: 0x06002BA0 RID: 11168 RVA: 0x000FC49C File Offset: 0x000FA69C
	private Dictionary<WeaponKey, cd1> a()
	{
		cd1 value = euf.i(this);
		Dictionary<WeaponKey, cd1> dictionary = new Dictionary<WeaponKey, cd1>();
		dictionary[WeaponKey.Primary] = value;
		dictionary[WeaponKey.Secondary] = value;
		return dictionary;
	}

	// Token: 0x06002BA1 RID: 11169 RVA: 0x000FC4C8 File Offset: 0x000FA6C8
	private void a(cdh A_0)
	{
		if (A_0 is d7s)
		{
			foreach (d3e d3e in this.aa)
			{
				if (d3e.GetType() == A_0.GetType())
				{
					d7s d7s = (d7s)d3e;
					if (d7s.co(A_0))
					{
						d7s.cn(A_0);
						return;
					}
				}
			}
		}
		cdh item = A_0.b3() as cdh;
		this.aa.Add(item);
	}

	// Token: 0x06002BA2 RID: 11170 RVA: 0x000FC574 File Offset: 0x000FA774
	private void a(b4t A_0)
	{
		if (this.ab != null)
		{
			foreach (RequirementRestrictedElementContainer<wq> requirementRestrictedElementContainer in this.ab)
			{
				if (requirementRestrictedElementContainer.a(this))
				{
					requirementRestrictedElementContainer.d = new bool?(true);
					requirementRestrictedElementContainer.c.dl(new ll(this), 1);
					A_0.qw(requirementRestrictedElementContainer.c, requirementRestrictedElementContainer.a);
				}
				else
				{
					requirementRestrictedElementContainer.d = new bool?(false);
				}
			}
		}
	}

	// Token: 0x06002BA3 RID: 11171 RVA: 0x000FC620 File Offset: 0x000FA820
	[dcc("C1:mOIU")]
	private void d(object A_0, by0 A_1)
	{
		a06 a = A_1.a() as a06;
		if (a != null)
		{
			this.a(a);
			if (a is cgd)
			{
				this.Defense.u();
			}
		}
		if (this.Vehicle != null)
		{
			this.Vehicle.k();
			return;
		}
		this.bl();
	}

	// Token: 0x06002BA4 RID: 11172 RVA: 0x000FC67C File Offset: 0x000FA87C
	[dcc("C1:mOIE")]
	private void c(object A_0, by0 A_1)
	{
		a06 a = A_1.a() as a06;
		if (a != null)
		{
			cd1 cd = A_1.a() as cd1;
			if (cd != null)
			{
				if (this.al.u() == cd)
				{
					this.b(a);
				}
			}
			else
			{
				this.b(a);
			}
		}
		if (this.Vehicle != null)
		{
			this.Vehicle.k();
			return;
		}
		this.bl();
	}

	// Token: 0x06002BA5 RID: 11173 RVA: 0x000FC6F0 File Offset: 0x000FA8F0
	[dcc("C1:mBIR")]
	private void b(object A_0, by0 A_1)
	{
		if (this.Vehicle != null)
		{
			this.Vehicle.k();
			return;
		}
		this.bl();
	}

	// Token: 0x06002BA6 RID: 11174 RVA: 0x000FC710 File Offset: 0x000FA910
	[dcc("C1:mBIA")]
	private void a(object A_0, by0 A_1)
	{
		if (this.Vehicle != null)
		{
			this.Vehicle.k();
			return;
		}
		this.bl();
	}

	// Token: 0x06002BA7 RID: 11175 RVA: 0x000FC730 File Offset: 0x000FA930
	public void OnDeserialization(object sender)
	{
		if (!Enumerable.Any<csn>(this.o.b, new Func<csn, bool>(efk.a.a.a)))
		{
			this.o.a(new c0b(0, this.o));
		}
	}

	// Token: 0x06002BA8 RID: 11176 RVA: 0x000FC78C File Offset: 0x000FA98C
	[OnDeserialized]
	private void a(StreamingContext A_0)
	{
		this.x.zx(new EventHandler<by0>(this.a));
		this.x.zz(new EventHandler<by0>(this.b));
		this.x.zw(new EventHandler<by0>(this.a));
		this.x.zy(new EventHandler<by0>(this.b));
	}

	// Token: 0x17000173 RID: 371
	// (get) Token: 0x06002BA9 RID: 11177 RVA: 0x000FC7F8 File Offset: 0x000FA9F8
	public string LocalizedName
	{
		get
		{
			if (aji.a == null)
			{
				return this.d;
			}
			string text = qv.b("EntityNames/" + this.d);
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return this.d;
		}
	}

	// Token: 0x040018B0 RID: 6320
	[NonSerialized]
	private bool a;

	// Token: 0x040018B1 RID: 6321
	private string b;

	// Token: 0x040018B2 RID: 6322
	private Guid c;

	// Token: 0x040018B3 RID: 6323
	private string d;

	// Token: 0x040018B4 RID: 6324
	private Gender e;

	// Token: 0x040018B5 RID: 6325
	private int f;

	// Token: 0x040018B6 RID: 6326
	private bool g;

	// Token: 0x040018B7 RID: 6327
	private bool h;

	// Token: 0x040018B8 RID: 6328
	private bool i;

	// Token: 0x040018B9 RID: 6329
	private bool j;

	// Token: 0x040018BA RID: 6330
	private cbg k = new cbg();

	// Token: 0x040018BB RID: 6331
	private Color l = Color.White;

	// Token: 0x040018BC RID: 6332
	private string m;

	// Token: 0x040018BD RID: 6333
	private bn2 n;

	// Token: 0x040018BE RID: 6334
	private ech o;

	// Token: 0x040018BF RID: 6335
	private an2 p;

	// Token: 0x040018C0 RID: 6336
	private cyr q = new cyr("Attacks");

	// Token: 0x040018C1 RID: 6337
	private cyr r = new cyr("Abilities");

	// Token: 0x040018C2 RID: 6338
	private cyr s = new cyr("Psi");

	// Token: 0x040018C3 RID: 6339
	private cyr t = new cyr("Gear");

	// Token: 0x040018C4 RID: 6340
	private c40 u;

	// Token: 0x040018C5 RID: 6341
	private br5 v;

	// Token: 0x040018C6 RID: 6342
	private aop w;

	// Token: 0x040018C7 RID: 6343
	private dcw x = new dcw(true);

	// Token: 0x040018C8 RID: 6344
	private acd y = new acd();

	// Token: 0x040018C9 RID: 6345
	[NonSerialized]
	private List<RequirementRestrictedElementContainer<d3e>> z = new List<RequirementRestrictedElementContainer<d3e>>();

	// Token: 0x040018CA RID: 6346
	[NonSerialized]
	private List<cdh> aa = new List<cdh>();

	// Token: 0x040018CB RID: 6347
	[NonSerialized]
	private List<RequirementRestrictedElementContainer<wq>> ab = new List<RequirementRestrictedElementContainer<wq>>();

	// Token: 0x040018CC RID: 6348
	private float ac;

	// Token: 0x040018CD RID: 6349
	private float ad = 1f;

	// Token: 0x040018CE RID: 6350
	private bool ae;

	// Token: 0x040018CF RID: 6351
	private bool af;

	// Token: 0x040018D0 RID: 6352
	private float? ag;

	// Token: 0x040018D1 RID: 6353
	private bool ah;

	// Token: 0x040018D2 RID: 6354
	private bool ai;

	// Token: 0x040018D3 RID: 6355
	private int aj;

	// Token: 0x040018D4 RID: 6356
	private nw ak;

	// Token: 0x040018D5 RID: 6357
	private dcu al;

	// Token: 0x040018D6 RID: 6358
	private Dictionary<WeaponKey, cd1> am = new Dictionary<WeaponKey, cd1>();

	// Token: 0x040018D7 RID: 6359
	private Dictionary<string, h> an = new Dictionary<string, h>();

	// Token: 0x040018D8 RID: 6360
	private double ao;

	// Token: 0x040018D9 RID: 6361
	private double ap;

	// Token: 0x040018DA RID: 6362
	private float aq;

	// Token: 0x040018DB RID: 6363
	private float ar = aiy.f;

	// Token: 0x040018DC RID: 6364
	private string @as;

	// Token: 0x040018DD RID: 6365
	private c2n at;

	// Token: 0x040018DE RID: 6366
	private bool au;

	// Token: 0x040018DF RID: 6367
	private float av = 1f;

	// Token: 0x040018E0 RID: 6368
	private float aw;

	// Token: 0x040018E1 RID: 6369
	private int ax;

	// Token: 0x040018E2 RID: 6370
	private double ay;

	// Token: 0x040018E3 RID: 6371
	private d8o az;

	// Token: 0x040018E4 RID: 6372
	private d8o a0;

	// Token: 0x040018E5 RID: 6373
	private CharacterImmunities a1;

	// Token: 0x040018E6 RID: 6374
	private CharacterImmunities a2;

	// Token: 0x040018E7 RID: 6375
	private Dictionary<CooldownCategory, double> a3 = new Dictionary<CooldownCategory, double>();

	// Token: 0x040018E8 RID: 6376
	private Dictionary<CooldownCategory, int> a4 = new Dictionary<CooldownCategory, int>();

	// Token: 0x040018E9 RID: 6377
	private Dictionary<SpecialCategory, dar> a5 = new Dictionary<SpecialCategory, dar>();

	// Token: 0x040018EA RID: 6378
	private int a6;

	// Token: 0x040018EB RID: 6379
	private db9 a7;

	// Token: 0x040018EC RID: 6380
	private PropertyCollection a8 = new PropertyCollection();

	// Token: 0x040018ED RID: 6381
	private bcx a9;

	// Token: 0x040018EE RID: 6382
	private Dictionary<string, f> ba = new Dictionary<string, f>();

	// Token: 0x040018EF RID: 6383
	[NonSerialized]
	public eom bb;

	// Token: 0x040018F0 RID: 6384
	[NonSerialized]
	public double bc;

	// Token: 0x040018F1 RID: 6385
	[NonSerialized]
	public string bd;

	// Token: 0x040018F2 RID: 6386
	[NonSerialized]
	public dgj be;

	// Token: 0x040018F3 RID: 6387
	[CompilerGenerated]
	private EventHandler<EventArgs> bf;

	// Token: 0x040018F4 RID: 6388
	[CompilerGenerated]
	private EventHandler<b8x> bg;

	// Token: 0x040018F5 RID: 6389
	[CompilerGenerated]
	private EventHandler<EventArgs> bh;

	// Token: 0x02001E2B RID: 7723
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x0600AB28 RID: 43816 RVA: 0x003F5D6C File Offset: 0x003F3F6C
		internal bool a(csn A_0)
		{
			return A_0 is c0b;
		}

		// Token: 0x04003FE5 RID: 16357
		public static readonly efk.a a = new efk.a();

		// Token: 0x04003FE6 RID: 16358
		public static Func<csn, bool> b;
	}
}
