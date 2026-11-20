using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001325 RID: 4901
[eiz("TEA")]
[Serializable]
public sealed class ale : Aspect<c5x>, e0p, ISerializable
{
	// Token: 0x06006F04 RID: 28420 RVA: 0x002E9530 File Offset: 0x002E7730
	private ale(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 27)
		{
			this.a = (A_0.GetValue("TEA:UPT", typeof(List<string>)) as List<string>);
			if (ell.a() >= 271)
			{
				this.b = A_0.GetBoolean("TEA:D");
			}
		}
		else
		{
			this.a = new List<string>();
		}
		if (ell.a() >= 615)
		{
			this.c = A_0.GetBoolean("TEA:IF");
		}
		if (ell.a() >= 637)
		{
			this.d = A_0.GetBoolean("TEA:LT");
		}
	}

	// Token: 0x06006F05 RID: 28421 RVA: 0x002E95EC File Offset: 0x002E77EC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TEA:UPT", this.a);
		info.AddValue("TEA:D", this.b);
		info.AddValue("TEA:IF", this.c);
		info.AddValue("TEA:LT", this.d);
	}

	// Token: 0x06006F06 RID: 28422 RVA: 0x002E9648 File Offset: 0x002E7848
	public ale(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006F07 RID: 28423 RVA: 0x002E9660 File Offset: 0x002E7860
	public fk a(object A_0, double A_1 = 0.0, int A_2 = 1, int A_3 = 0)
	{
		fk fk = new fk(this, A_0, null, false, 0);
		fk.a(A_1);
		fk.c(A_2);
		fk.b(A_3);
		if (base.a8().i.b != null)
		{
			base.a8().i.b.a(fk, atp.a, true, false);
			return fk;
		}
		return null;
	}

	// Token: 0x06006F08 RID: 28424 RVA: 0x002E96C0 File Offset: 0x002E78C0
	public e1i a(object A_0, float A_1, int A_2 = 1, int A_3 = 0)
	{
		e1i e1i = new e1i(this, A_0, A_1);
		e1i.c(A_2);
		e1i.b(A_3);
		if (base.a8().i.b != null)
		{
			base.a8().i.b.a(e1i, atp.a, true, false);
			return e1i;
		}
		return null;
	}

	// Token: 0x06006F09 RID: 28425 RVA: 0x002E9718 File Offset: 0x002E7918
	public djk a(ak1 A_0, double A_1 = 0.0, int A_2 = 1, int A_3 = 0, bool A_4 = true)
	{
		djk djk = new djk(this, A_0);
		djk.a(A_1);
		djk.c(A_2);
		djk.b(A_3);
		if (A_4)
		{
			if (base.a8().i.b == null)
			{
				return null;
			}
			base.a8().i.b.a(djk, atp.a, true, false);
		}
		return djk;
	}

	// Token: 0x06006F0A RID: 28426 RVA: 0x002E9780 File Offset: 0x002E7980
	public void a(ak1 A_0, ya A_1)
	{
		czh.a(A_0, "tile");
		awx awx = new awx();
		awx.a(m7.b);
		djk item = new djk(this, A_0);
		awx.ad().Add(item);
		if (A_1 != null)
		{
			ed6 item2 = new ed6(A_0, base.a8(), A_1);
			awx.ad().Add(item2);
		}
		if (base.a8().i.b != null)
		{
			base.a8().i.b.a(awx, atp.a, true, false);
		}
	}

	// Token: 0x06006F0B RID: 28427 RVA: 0x002E9808 File Offset: 0x002E7A08
	public awx b(b0b A_0, List<HorizontalDirection> A_1, int A_2 = 1, bool A_3 = false, string A_4 = null)
	{
		czh.a(A_0, "entity");
		awx awx = this.a(A_0, A_1, A_2, A_3, A_4);
		if (base.a8().i.b != null)
		{
			base.a8().i.b.a(awx, atp.a, true, false);
		}
		return awx;
	}

	// Token: 0x06006F0C RID: 28428 RVA: 0x002E9860 File Offset: 0x002E7A60
	public awx a(b0b A_0, List<HorizontalDirection> A_1, int A_2 = 1, bool A_3 = false, string A_4 = null)
	{
		czh.a(A_0, "entity");
		bim aspect = A_0.GetAspect<bim>();
		awx awx = new awx();
		awx.a(m7.b);
		if (aspect != null)
		{
			if (aspect.ac() != 0f)
			{
				e1i e1i = new e1i(this, A_0, aspect.ac());
				e1i.c(A_2);
				awx.ad().Add(e1i);
			}
			else
			{
				fk fk = new fk(this, A_0, A_1, A_3, 0);
				fk.a(aspect.u());
				fk.c(A_2);
				awx.ad().Add(fk);
			}
			if (aspect.aa() && base.a8().h.b != null)
			{
				awx.ad().Add(new aro(base.a8().h.b));
				awx.ad().Add(new bm3(100));
			}
			if (aspect.x() && aspect.p <= 0 && base.a8().h.b != null)
			{
				awx.ad().Add(new e4t(base.a8().h.b, CharacterState.OperateShort, dz6.b(100), 0, null, 1));
			}
			awx.ad().Add(new b9t(base.a8(), aspect, A_4));
		}
		return awx;
	}

	// Token: 0x06006F0D RID: 28429 RVA: 0x002E99C0 File Offset: 0x002E7BC0
	public eyu p3(ee4 A_0, cr6 A_1)
	{
		return this.a(A_0, A_1, null, null);
	}

	// Token: 0x06006F0E RID: 28430 RVA: 0x002E99CC File Offset: 0x002E7BCC
	public eyu a(ee4 A_0, cr6 A_1, d25 A_2 = null, HashSet<Guid> A_3 = null)
	{
		eyu eyu = default(eyu);
		eyu.f = true;
		eyu.b = ac7.a;
		eyu.c = false;
		eyu.a = 1f;
		d25 d;
		if (A_2 != null)
		{
			d = A_2;
		}
		else if (A_1 != null)
		{
			d = (A_1.auq() as d25);
		}
		else
		{
			d = null;
		}
		if (base.a8().Zone == null || A_0.a.X < 0 || A_0.a.Y < 0)
		{
			eyu.b = ac7.b;
			return eyu;
		}
		aud aud = base.a8().Zone.b(A_0.b);
		ak1 ak = aud.b(A_0.a.X / 4, A_0.a.Y / 4);
		if (ak == null)
		{
			eyu.b = ac7.b;
			return eyu;
		}
		if (d != null && d.i != null)
		{
			r0 r = new r0(A_0.b, new Vector2((float)ak.Location.X, (float)ak.Location.Y));
			if (!d.i.Contains(r))
			{
				eyu.b = ac7.a;
				return eyu;
			}
		}
		if (this.a(ak))
		{
			bool flag;
			if (!this.a(ak, A_1, d, out flag))
			{
				eyu.b = ac7.a;
				return eyu;
			}
			if (flag)
			{
				eyu.e = true;
			}
			else
			{
				eyu.d = true;
			}
		}
		bool flag2 = false;
		bool flag3 = false;
		if (this.a(ref eyu, ak, d))
		{
			return eyu;
		}
		if (A_0.a.X % 4 == 3)
		{
			flag2 = true;
			ak1 ak2 = aud.b(ak.Location.X + 1, ak.Location.Y);
			if (ak2 == null)
			{
				eyu.b = ac7.b;
				return eyu;
			}
			if (this.a(ref eyu, ak2, d))
			{
				return eyu;
			}
			if (this.a(ak2))
			{
				bool flag4;
				if (!this.a(ak2, A_1, d, out flag4))
				{
					eyu.b = ac7.a;
					return eyu;
				}
				if (flag4)
				{
					eyu.e = true;
				}
				else
				{
					eyu.d = true;
				}
			}
		}
		if (A_0.a.Y % 4 == 3)
		{
			flag3 = true;
			ak1 ak3 = aud.b(ak.Location.X, ak.Location.Y + 1);
			if (ak3 == null)
			{
				eyu.b = ac7.b;
				return eyu;
			}
			if (this.a(ref eyu, ak3, d))
			{
				return eyu;
			}
			if (this.a(ak3))
			{
				bool flag5;
				if (!this.a(ak3, A_1, d, out flag5))
				{
					eyu.b = ac7.a;
					return eyu;
				}
				if (flag5)
				{
					eyu.e = true;
				}
				else
				{
					eyu.d = true;
				}
			}
		}
		if (flag2 && flag3)
		{
			ak1 ak4 = aud.b(ak.Location.X + 1, ak.Location.Y + 1);
			if (ak4 == null)
			{
				eyu.b = ac7.b;
				return eyu;
			}
			if (this.a(ref eyu, ak4, d))
			{
				return eyu;
			}
			if (this.a(ak4))
			{
				bool flag6;
				if (!this.a(ak4, A_1, d, out flag6))
				{
					eyu.b = ac7.a;
					return eyu;
				}
				if (flag6)
				{
					eyu.e = true;
				}
				else
				{
					eyu.d = true;
				}
			}
		}
		long num;
		if (A_3 != null)
		{
			num = ak.a(A_3);
		}
		else
		{
			num = ak.f(base.a8());
		}
		if (num == 0L)
		{
			eyu.b = ac7.c;
			return eyu;
		}
		byte b = (byte)(A_0.a.Y % 4 * 4 + A_0.a.X % 4);
		if ((bcj.a(new byte[]
		{
			b
		}) & num) == 0L)
		{
			eyu.b = ac7.c;
			return eyu;
		}
		if (!this.a(ak, b, A_1, d))
		{
			if (!base.a8().IsPlayer && d != null && d.h != null)
			{
				HashSet<Guid> hashSet = new HashSet<Guid>(d.h);
				hashSet.Add(base.a8().qe());
				long num2 = ak.a(hashSet);
				if ((bcj.a(new byte[]
				{
					b
				}) & num2) == 0L)
				{
					eyu.b = ac7.c;
					eyu.a = Math.Max(10000f, eyu.a);
					return eyu;
				}
			}
			eyu.b = ac7.a;
			return eyu;
		}
		eyu.b = ac7.c;
		return eyu;
	}

	// Token: 0x06006F0F RID: 28431 RVA: 0x002E9E60 File Offset: 0x002E8060
	public bool a(ak1 A_0)
	{
		bjp bjp = A_0.Formation;
		if (A_0 == null)
		{
			return false;
		}
		if (!base.a8().IsPlayer && bjp.c(16777216L))
		{
			return true;
		}
		if (this.d)
		{
			return bjp.c(1L);
		}
		if (base.a8().h.b != null && base.a8().h.b.aa().b(d8o.l))
		{
			if (!bjp.c(64L) || bjp.c(262308L))
			{
				return true;
			}
		}
		else if (base.a8().h.b != null && base.a8().h.b.aa().b(d8o.n))
		{
			if (!bjp.c(524352L) || bjp.c(262308L))
			{
				return true;
			}
		}
		else if (bjp.c(2L) && (!bjp.c(128L) || bjp.c(36L)))
		{
			return true;
		}
		if (!base.a8().IsPlayer && bjp.c(65536L))
		{
			if (base.a8().h.b == null)
			{
				return true;
			}
			if (base.a8().h.b.aa().Defense.af()[DamageType.Electricity].c() < 1.0)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06006F10 RID: 28432 RVA: 0x002EA018 File Offset: 0x002E8218
	private bool a(ref eyu A_0, ak1 A_1, d25 A_2)
	{
		if (A_1.Formation.b(2048L) && !base.a8().IsPlayer)
		{
			A_0.a = 10f;
		}
		if (!this.c && A_1.Formation.b(8192L) && !base.a8().IsPlayer && base.a8().h.b != null)
		{
			if (!dz6.e() && !cun.a(ref A_2) && (A_2 == null || A_2.f == 0))
			{
				A_0.b = ac7.a;
				return true;
			}
			if (base.a8().h.b.aa().b(d8o.g) && (A_2 == null || A_2.f == 0))
			{
				A_0.b = ac7.a;
				return true;
			}
			int num = dd5.a(A_1);
			if (num > 0)
			{
				double num2 = base.a8().h.b.aa().Defense.af()[DamageType.Heat].c();
				int num3 = base.a8().h.b.aa().Defense.af()[DamageType.Heat].a();
				if (num2 < 0.9 && num3 < 60)
				{
					float num4 = euf.f(base.a8().h.b.aa());
					if (num2 > 0.4 + (double)num * 0.1 || num3 > 5 + 10 * num)
					{
						A_0.a = 1.5f;
					}
					else
					{
						if (A_2 == null || A_2.f == 0)
						{
							if (num4 < 0.5f)
							{
								A_0.b = ac7.a;
								return true;
							}
							if (num >= 4 || num4 < 0.5f + 0.1f * (float)num)
							{
								A_0.b = ac7.a;
								return true;
							}
						}
						A_0.a = 1000f;
					}
				}
			}
		}
		if (A_1.Formation.b(16384L) && !base.a8().IsPlayer && (base.a8().h.b == null || (!base.a8().h.b.aa().b(d8o.e) && base.a8().h.b.aa().Defense.af()[DamageType.Bio].c() < 1.0)) && base.a8().h.b != null)
		{
			if (!dz6.e() && !cun.a(ref A_2) && (A_2 == null || A_2.g == 0))
			{
				A_0.b = ac7.a;
				return true;
			}
			int num5 = bpv.a(A_1);
			if (num5 > 0)
			{
				double num6 = base.a8().h.b.aa().Defense.af()[DamageType.Bio].c();
				int num7 = base.a8().h.b.aa().Defense.af()[DamageType.Bio].a();
				if (num6 < 0.75 && num7 < 40)
				{
					float num8 = euf.f(base.a8().h.b.aa());
					if (num6 > 0.2 + (double)num5 * 0.1 || num7 > 5 + 5 * num5)
					{
						A_0.a = 1.5f;
					}
					else
					{
						A_0.a = 10f;
						if (A_2 == null || A_2.f == 0)
						{
							if (num8 < 0.2f)
							{
								A_0.b = ac7.a;
								return true;
							}
							if (num8 < 0.5f)
							{
								A_0.a = 1000f;
							}
							else if (num5 >= 4 || num8 < 0.5f + 0.1f * (float)num5)
							{
								A_0.a = 1000f;
							}
						}
					}
				}
			}
		}
		if (A_1.Formation.b(1024L) && !base.a8().h.b.aa().b(d8o.q))
		{
			if (A_2 != null && A_2.e != null && A_2.e.Value.b == A_1.Area.c() && new Point(A_2.e.Value.a.X / 4, A_2.e.Value.a.Y / 4) == A_1.Location)
			{
				return false;
			}
			foreach (b0b b0b in A_1.c.Values)
			{
				ed2 ed = ((c5x)b0b).r.b as ed2;
				if (ed != null)
				{
					if (ed.f != null && base.a8().h.b != null && ed.f == base.a8().h.b.aa().FactionId)
					{
						if (base.a8().h.b.aa() is e3q)
						{
							A_0.a = 1000f;
							return false;
						}
						A_0.b = ac7.a;
						return true;
					}
					else if (ed.a.Contains(base.a8().qe()) || ed.b.Contains(base.a8().h.b.aa().FactionId))
					{
						A_0.a = 1000f;
						return false;
					}
				}
			}
			return false;
		}
		return false;
	}

	// Token: 0x06006F11 RID: 28433 RVA: 0x002EA67C File Offset: 0x002E887C
	private bool a(ak1 A_0, byte A_1, cr6 A_2, d25 A_3)
	{
		if (A_2 != null && A_3 != null)
		{
			bm6 bm = base.a8().t.b;
			if (bm != null)
			{
				foreach (b0b b0b in A_0.c.Values)
				{
					c5x c5x = (c5x)b0b;
					if (c5x.h.b != null && c5x.h.b.aa().SpecialStates.g && (base.a8().h.b == null || !(c5x.h.b.aa().FactionId == base.a8().h.b.aa().FactionId)))
					{
						bool flag;
						if (!A_3.d.TryGetValue(c5x.qe(), out flag))
						{
							erl erl = bm.a(c5x.qe());
							flag = (erl == null || erl.f() != cem.d);
							A_3.d[c5x.qe()] = flag;
						}
						bjp bjp;
						if (flag && A_0.l.TryGetValue(c5x.qe(), out bjp) && (bjp.b() & bcj.a(new byte[]
						{
							A_1
						})) != 0L)
						{
							return true;
						}
					}
				}
				return false;
			}
		}
		return false;
	}

	// Token: 0x06006F12 RID: 28434 RVA: 0x002EA820 File Offset: 0x002E8A20
	private bool a(ak1 A_0, cr6 A_1, d25 A_2, out bool A_3)
	{
		A_3 = false;
		if (A_1 != null && A_2 != null)
		{
			A_3 = A_0.Formation.b(4194304L);
			if ((A_3 && A_2 != null && A_2.c) || (A_0.Formation.b(512L) && A_2 != null && A_2.b))
			{
				bool flag = false;
				if (A_2.a.TryGetValue(A_0, out flag))
				{
					return flag;
				}
				foreach (b0b b0b in A_0.c.Values)
				{
					c5x c5x = (c5x)b0b;
					cnb cnb = c5x.s.b as cnb;
					if (cnb != null && cnb.ab())
					{
						d2b aspect = c5x.GetAspect<d2b>();
						if (aspect != null)
						{
							amc amc = base.a8().h.b;
							if (amc != null && aspect.o() == d1c.c)
							{
								c3g aspect2 = c5x.GetAspect<c3g>();
								if (aspect2 != null && !aspect2.a(amc.aa()))
								{
									flag = false;
									break;
								}
							}
							flag = (!aspect.n() || aspect.a(amc, true) == c9b.a);
							break;
						}
						flag = true;
						break;
					}
				}
				A_2.a[A_0] = flag;
				return flag;
			}
		}
		return false;
	}

	// Token: 0x04002D6F RID: 11631
	public List<string> a = new List<string>();

	// Token: 0x04002D70 RID: 11632
	public bool b;

	// Token: 0x04002D71 RID: 11633
	public bool c;

	// Token: 0x04002D72 RID: 11634
	public bool d;
}
