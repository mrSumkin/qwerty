using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02000FBF RID: 4031
[eiz("CHWTC")]
[Serializable]
public sealed class cvw : dnh, ISerializable
{
	// Token: 0x060052A0 RID: 21152 RVA: 0x0024E4DC File Offset: 0x0024C6DC
	private cvw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid?)A_0.GetValue("CHWTC:I", typeof(Guid?));
		this.b = A_0.GetString("CHWTC:A");
		this.c = A_0.GetBoolean("CHWTC:N");
		this.d = A_0.GetBoolean("CHWTC:B");
		this.e = (btz)A_0.GetValue("CHWTC:T", typeof(btz));
		this.f = (A_0.GetValue("CHWTC:S", typeof(WeaponSubtype?)) as WeaponSubtype?);
		if (ell.a() >= 520)
		{
			this.g = (A_0.GetValue("CHWTC:ST", typeof(bvl?)) as bvl?);
		}
	}

	// Token: 0x060052A1 RID: 21153 RVA: 0x0024E5C0 File Offset: 0x0024C7C0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CHWTC:I", this.a);
		info.AddValue("CHWTC:A", this.b);
		info.AddValue("CHWTC:N", this.c);
		info.AddValue("CHWTC:B", this.d);
		info.AddValue("CHWTC:T", this.e);
		info.AddValue("CHWTC:S", this.f);
		info.AddValue("CHWTC:ST", this.g);
	}

	// Token: 0x060052A2 RID: 21154 RVA: 0x0024E660 File Offset: 0x0024C860
	public string c()
	{
		return this.b;
	}

	// Token: 0x060052A3 RID: 21155 RVA: 0x0024E668 File Offset: 0x0024C868
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060052A4 RID: 21156 RVA: 0x0024E674 File Offset: 0x0024C874
	public Guid? e()
	{
		return this.a;
	}

	// Token: 0x060052A5 RID: 21157 RVA: 0x0024E67C File Offset: 0x0024C87C
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060052A6 RID: 21158 RVA: 0x0024E688 File Offset: 0x0024C888
	public bool a()
	{
		return this.c;
	}

	// Token: 0x060052A7 RID: 21159 RVA: 0x0024E690 File Offset: 0x0024C890
	public void b(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060052A8 RID: 21160 RVA: 0x0024E69C File Offset: 0x0024C89C
	public bool d()
	{
		return this.d;
	}

	// Token: 0x060052A9 RID: 21161 RVA: 0x0024E6A4 File Offset: 0x0024C8A4
	public void a(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060052AA RID: 21162 RVA: 0x0024E6B0 File Offset: 0x0024C8B0
	public btz g()
	{
		return this.e;
	}

	// Token: 0x060052AB RID: 21163 RVA: 0x0024E6B8 File Offset: 0x0024C8B8
	public void a(btz A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060052AC RID: 21164 RVA: 0x0024E6C4 File Offset: 0x0024C8C4
	public WeaponSubtype? f()
	{
		return this.f;
	}

	// Token: 0x060052AD RID: 21165 RVA: 0x0024E6CC File Offset: 0x0024C8CC
	public void a(WeaponSubtype? A_0)
	{
		this.f = A_0;
	}

	// Token: 0x060052AE RID: 21166 RVA: 0x0024E6D8 File Offset: 0x0024C8D8
	public bvl? b()
	{
		return this.g;
	}

	// Token: 0x060052AF RID: 21167 RVA: 0x0024E6E0 File Offset: 0x0024C8E0
	public void a(bvl? A_0)
	{
		this.g = A_0;
	}

	// Token: 0x060052B0 RID: 21168 RVA: 0x0024E6EC File Offset: 0x0024C8EC
	public cvw()
	{
	}

	// Token: 0x060052B1 RID: 21169 RVA: 0x0024E6F8 File Offset: 0x0024C8F8
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			b0b b0b = null;
			if (this.g == null || this.g.Value == bvl.a || this.g.Value == bvl.e)
			{
				if (this.a != null && !string.IsNullOrEmpty(this.b))
				{
					aud aud = serviceOrThrow.aqw().n(this.b);
					if (aud != null)
					{
						b0b = new ar7(this.a.Value, aud).ao();
					}
				}
				else
				{
					b0b = (A_0.GetPropertyValue(c49.b) as b0b);
				}
			}
			else
			{
				switch (this.g.Value)
				{
				case bvl.b:
					b0b = (A_0.GetPropertyValue(c49.a) as b0b);
					break;
				case bvl.c:
					b0b = (A_0.GetPropertyValue(c49.b) as b0b);
					break;
				case bvl.d:
					if (serviceOrThrow != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
					{
						b0b = serviceOrThrow.aqu().v().b();
					}
					break;
				}
			}
			if (b0b != null)
			{
				amc aspect = b0b.GetAspect<amc>();
				if (aspect != null)
				{
					List<cd1> list = new List<cd1>();
					list.Add(aspect.aa().Offense.u());
					if (this.d)
					{
						list.Add(aspect.aa().Offense.q());
					}
					foreach (cd1 cd in list)
					{
						if (cd.TypedDefinition.e() == this.e)
						{
							if (this.f != null)
							{
								WeaponSubtype? weaponSubtype = euf.d(cd.TypedDefinition);
								WeaponSubtype value = this.f.Value;
								if (!(weaponSubtype.GetValueOrDefault() == value & weaponSubtype != null))
								{
									continue;
								}
							}
							flag = true;
							break;
						}
					}
				}
			}
		}
		return flag ^ this.c;
	}

	// Token: 0x040021D3 RID: 8659
	private Guid? a;

	// Token: 0x040021D4 RID: 8660
	private string b;

	// Token: 0x040021D5 RID: 8661
	private bool c;

	// Token: 0x040021D6 RID: 8662
	private bool d;

	// Token: 0x040021D7 RID: 8663
	private btz e;

	// Token: 0x040021D8 RID: 8664
	private WeaponSubtype? f;

	// Token: 0x040021D9 RID: 8665
	private bvl? g;
}
