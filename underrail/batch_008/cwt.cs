using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001C11 RID: 7185
[eiz("AR2")]
[Serializable]
public sealed class cwt : ISerializable
{
	// Token: 0x06009DBF RID: 40383 RVA: 0x003DF2EC File Offset: 0x003DD4EC
	private cwt(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.b = A_0.GetBoolean("AR2:H");
			this.e = A_0.GetBoolean("AR2:CH");
			di7.ReadList<csk>("AR2:D", ref this.f, A_0);
			di7.ReadList<edm>("AR2:OHE", ref this.g, A_0);
			this.h = (ImpactSpeed)A_0.GetValue("AR2:IS", typeof(ImpactSpeed));
			this.i = (ap9)A_0.GetValue("AR2:A", typeof(ap9));
			this.j = (ap9)A_0.GetValue("AR2:T", typeof(ap9));
			this.k = A_0.GetString("AR2:M");
			this.l = A_0.GetBoolean("AR2:BS");
			this.p = A_0.GetBoolean("AR2:BR");
			this.q = A_0.GetBoolean("AR2:E");
			this.r = A_0.GetBoolean("AR2:P");
			this.s = A_0.GetBoolean("AR2:NP");
			this.t = A_0.GetDouble("AR2:PM");
			this.a = (c3u)A_0.GetValue("AR2:TG", typeof(c3u));
			this.u = A_0.GetBoolean("AR2:S");
			this.v = A_0.GetString("AR2:EL");
			this.w = A_0.GetBoolean("AR2:I");
			if (ell.a() >= 65)
			{
				this.x = (AmmoType)A_0.GetValue("AR2:Y", typeof(AmmoType));
			}
			if (ell.a() >= 76)
			{
				this.y = A_0.GetString("AR2:CM");
			}
			if (ell.a() >= 92)
			{
				this.z = A_0.GetBoolean("AR2:ML");
			}
			if (ell.a() >= 93)
			{
				di7.ReadList<d09>("AR:X", ref this.ab, A_0);
			}
			if (ell.a() >= 114)
			{
				this.aa = A_0.GetBoolean("AR2:U");
			}
			if (ell.a() >= 159)
			{
				this.ac = (A_0.GetValue("AR2:C", typeof(object[])) as object[]);
			}
			if (ell.a() >= 164)
			{
				this.d = A_0.GetBoolean("AR2:B");
			}
			if (ell.a() >= 170)
			{
				this.ae = (A_0.GetValue("AR2:O", typeof(WeaponSubtype?)) as WeaponSubtype?);
				this.ad = (A_0.GetValue("AR2:CP", typeof(PropertyCollection)) as PropertyCollection);
			}
			else
			{
				this.ad = new PropertyCollection();
			}
			if (ell.a() >= 172)
			{
				this.af = (Guid)A_0.GetValue("AR2:SA", typeof(Guid));
			}
			if (ell.a() >= 200)
			{
				this.n = A_0.GetDouble("AR2:SB");
			}
			if (ell.a() >= 279)
			{
				this.m = A_0.GetBoolean("AR2:BT");
			}
			if (ell.a() >= 343)
			{
				this.o = A_0.GetDouble("AR2:RB");
			}
			if (ell.a() >= 380)
			{
				this.c = (A_0.GetValue("AR2:HV", typeof(bool?)) as bool?);
			}
			if (ell.a() >= 485)
			{
				this.ag = A_0.GetBoolean("AR2:IP");
			}
			if (ell.a() >= 527)
			{
				this.ah = A_0.GetBoolean("AR2:NL");
			}
			if (ell.a() >= 529)
			{
				this.ai = (A_0.GetValue("AR2:CW", typeof(cd1)) as cd1);
			}
			if (ell.a() >= 547)
			{
				this.aj = A_0.GetString("AR2:AM");
			}
			if (ell.a() >= 668)
			{
				this.ak = A_0.GetDouble("AR2:EI");
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(cwt))
			{
				this.b = A_0.GetBoolean("Hit");
				this.e = A_0.GetBoolean("CriticalHit");
				this.f = (List<csk>)A_0.GetValue("Damages", typeof(List<csk>));
				this.g = (List<edm>)A_0.GetValue("OnHitEffects", typeof(List<edm>));
				this.h = (ImpactSpeed)A_0.GetValue("ImpactSpeed", typeof(ImpactSpeed));
				this.i = (ap9)A_0.GetValue("Attacker", typeof(ap9));
				this.j = (ap9)A_0.GetValue("Цель", typeof(ap9));
				this.k = A_0.GetString("Medium");
				this.l = A_0.GetBoolean("BypassShield");
				this.p = A_0.GetBoolean("BypassResistance");
				this.q = A_0.GetBoolean("Evadeable");
				this.r = A_0.GetBoolean("Periodic");
				this.s = A_0.GetBoolean("NoPushback");
				this.t = A_0.GetDouble("PushbackModifier");
				return;
			}
			this.b = A_0.GetBoolean("AttackResult+Hit");
			this.e = A_0.GetBoolean("AttackResult+CriticalHit");
			this.f = (List<csk>)A_0.GetValue("AttackResult+Damages", typeof(List<csk>));
			this.g = (List<edm>)A_0.GetValue("AttackResult+OnHitEffects", typeof(List<edm>));
			this.h = (ImpactSpeed)A_0.GetValue("AttackResult+ImpactSpeed", typeof(ImpactSpeed));
			this.i = (ap9)A_0.GetValue("AttackResult+Attacker", typeof(ap9));
			this.j = (ap9)A_0.GetValue("AttackResult+Target", typeof(ap9));
			this.k = A_0.GetString("AttackResult+Medium");
			this.l = A_0.GetBoolean("AttackResult+BypassShield");
			this.p = A_0.GetBoolean("AttackResult+BypassResistance");
			this.q = A_0.GetBoolean("AttackResult+Evadeable");
			this.r = A_0.GetBoolean("AttackResult+Periodic");
			this.s = A_0.GetBoolean("AttackResult+NoPushback");
			this.t = A_0.GetDouble("AttackResult+PushbackModifier");
		}
	}

	// Token: 0x06009DC0 RID: 40384 RVA: 0x003DFA08 File Offset: 0x003DDC08
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("AR2:H", this.b);
		info.AddValue("AR2:CH", this.e);
		di7.WriteList<csk>("AR2:D", this.f, info);
		di7.WriteList<edm>("AR2:OHE", this.g, info);
		info.AddValue("AR2:IS", this.h);
		info.AddValue("AR2:A", this.i);
		info.AddValue("AR2:T", this.j);
		info.AddValue("AR2:M", this.k);
		info.AddValue("AR2:BS", this.l);
		info.AddValue("AR2:BR", this.p);
		info.AddValue("AR2:E", this.q);
		info.AddValue("AR2:P", this.r);
		info.AddValue("AR2:NP", this.s);
		info.AddValue("AR2:PM", this.t);
		info.AddValue("AR2:TG", this.a);
		info.AddValue("AR2:S", this.u);
		info.AddValue("AR2:EL", this.v);
		info.AddValue("AR2:I", this.w);
		info.AddValue("AR2:Y", this.x);
		info.AddValue("AR2:CM", this.y);
		info.AddValue("AR2:ML", this.z);
		di7.WriteList<d09>("AR:X", this.ab, info);
		info.AddValue("AR2:U", this.aa);
		info.AddValue("AR2:C", this.ac);
		info.AddValue("AR2:B", this.d);
		info.AddValue("AR2:O", this.ae);
		info.AddValue("AR2:CP", this.ad);
		info.AddValue("AR2:SA", this.af);
		info.AddValue("AR2:SB", this.n);
		info.AddValue("AR2:BT", this.m);
		info.AddValue("AR2:RB", this.o);
		info.AddValue("AR2:HV", this.c);
		info.AddValue("AR2:IP", this.ag);
		info.AddValue("AR2:NL", this.ah);
		info.AddValue("AR2:CW", this.ai);
		info.AddValue("AR2:AM", this.aj);
		info.AddValue("AR2:EI", this.ak);
	}

	// Token: 0x06009DC1 RID: 40385 RVA: 0x003DFCA8 File Offset: 0x003DDEA8
	public cwt()
	{
	}

	// Token: 0x06009DC2 RID: 40386 RVA: 0x003DFCF8 File Offset: 0x003DDEF8
	public bool a(c3u A_0)
	{
		return (this.a & A_0) == A_0;
	}

	// Token: 0x06009DC3 RID: 40387 RVA: 0x003DFD08 File Offset: 0x003DDF08
	public cwt a()
	{
		cwt cwt = new cwt();
		cwt.x = this.x;
		cwt.i = ((this.i != null) ? this.i.b() : null);
		cwt.j = ((this.j != null) ? this.j.b() : null);
		cwt.d = this.d;
		cwt.p = this.p;
		cwt.o = this.o;
		cwt.l = this.l;
		cwt.m = this.m;
		cwt.e = this.e;
		cwt.y = this.y;
		cwt.ad = this.ad.Clone();
		cwt.ac = ((this.ac != null) ? Enumerable.ToArray<object>(this.ac) : null);
		cwt.f = new List<csk>(this.f);
		cwt.v = this.v;
		cwt.q = this.q;
		cwt.b = this.b;
		cwt.c = this.c;
		cwt.h = this.h;
		cwt.w = this.w;
		cwt.z = this.z;
		cwt.aa = this.aa;
		cwt.k = this.k;
		cwt.s = this.s;
		cwt.ab = new List<d09>(this.ab);
		cwt.g = new List<edm>(this.g);
		cwt.ae = this.ae;
		cwt.n = this.n;
		cwt.r = this.r;
		cwt.t = this.t;
		cwt.u = this.u;
		cwt.af = this.af;
		cwt.a = this.a;
		cwt.ag = this.ag;
		cwt.ah = this.ah;
		if (this.ai != null)
		{
			cwt.ai = (this.ai.fy() as cd1);
		}
		cwt.aj = this.aj;
		return cwt;
	}

	// Token: 0x04003CF9 RID: 15609
	public c3u a;

	// Token: 0x04003CFA RID: 15610
	public bool b;

	// Token: 0x04003CFB RID: 15611
	public bool? c;

	// Token: 0x04003CFC RID: 15612
	public bool d;

	// Token: 0x04003CFD RID: 15613
	public bool e;

	// Token: 0x04003CFE RID: 15614
	public List<csk> f = new List<csk>();

	// Token: 0x04003CFF RID: 15615
	public List<edm> g = new List<edm>();

	// Token: 0x04003D00 RID: 15616
	public ImpactSpeed h;

	// Token: 0x04003D01 RID: 15617
	public ap9 i;

	// Token: 0x04003D02 RID: 15618
	public ap9 j;

	// Token: 0x04003D03 RID: 15619
	public string k;

	// Token: 0x04003D04 RID: 15620
	public bool l;

	// Token: 0x04003D05 RID: 15621
	public bool m;

	// Token: 0x04003D06 RID: 15622
	public double n;

	// Token: 0x04003D07 RID: 15623
	public double o;

	// Token: 0x04003D08 RID: 15624
	public bool p;

	// Token: 0x04003D09 RID: 15625
	public bool q;

	// Token: 0x04003D0A RID: 15626
	public bool r;

	// Token: 0x04003D0B RID: 15627
	public bool s;

	// Token: 0x04003D0C RID: 15628
	public double t = 1.0;

	// Token: 0x04003D0D RID: 15629
	public bool u;

	// Token: 0x04003D0E RID: 15630
	public string v;

	// Token: 0x04003D0F RID: 15631
	public bool w;

	// Token: 0x04003D10 RID: 15632
	public AmmoType x;

	// Token: 0x04003D11 RID: 15633
	public string y;

	// Token: 0x04003D12 RID: 15634
	public bool z;

	// Token: 0x04003D13 RID: 15635
	public bool aa;

	// Token: 0x04003D14 RID: 15636
	public List<d09> ab = new List<d09>();

	// Token: 0x04003D15 RID: 15637
	public object[] ac;

	// Token: 0x04003D16 RID: 15638
	public PropertyCollection ad = new PropertyCollection();

	// Token: 0x04003D17 RID: 15639
	public WeaponSubtype? ae;

	// Token: 0x04003D18 RID: 15640
	public Guid af;

	// Token: 0x04003D19 RID: 15641
	public bool ag;

	// Token: 0x04003D1A RID: 15642
	public bool ah;

	// Token: 0x04003D1B RID: 15643
	public cd1 ai;

	// Token: 0x04003D1C RID: 15644
	public string aj;

	// Token: 0x04003D1D RID: 15645
	public double ak;
}
