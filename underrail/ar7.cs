using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x02000263 RID: 611
[eiz("ER")]
[Serializable]
public sealed class ar7 : TypedObjectReference<b0b>, ISerializable
{
	// Token: 0x06001186 RID: 4486 RVA: 0x00048294 File Offset: 0x00046494
	private ar7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetString("ER:PN");
			this.b = (Guid)A_0.GetValue("ER:ZI", typeof(Guid));
			this.c = (Guid)A_0.GetValue("ER:AI", typeof(Guid));
			return;
		}
		if (base.GetType() == typeof(ar7))
		{
			this.a = A_0.GetString("_PlayfieldName");
			this.b = (Guid)A_0.GetValue("_ZoneId", typeof(Guid));
			this.c = (Guid)A_0.GetValue("_AreaId", typeof(Guid));
			return;
		}
		this.a = A_0.GetString("EntityReference+_PlayfieldName");
		this.b = (Guid)A_0.GetValue("EntityReference+_ZoneId", typeof(Guid));
		this.c = (Guid)A_0.GetValue("EntityReference+_AreaId", typeof(Guid));
	}

	// Token: 0x06001187 RID: 4487 RVA: 0x000483C4 File Offset: 0x000465C4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ER:PN", this.a);
		info.AddValue("ER:ZI", this.b);
		info.AddValue("ER:AI", this.c);
	}

	// Token: 0x170000DA RID: 218
	// (get) Token: 0x06001188 RID: 4488 RVA: 0x00048418 File Offset: 0x00046618
	// (set) Token: 0x06001189 RID: 4489 RVA: 0x00048420 File Offset: 0x00046620
	public string PlayfieldName
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x170000DB RID: 219
	// (get) Token: 0x0600118A RID: 4490 RVA: 0x0004842C File Offset: 0x0004662C
	// (set) Token: 0x0600118B RID: 4491 RVA: 0x00048434 File Offset: 0x00046634
	public Guid ZoneId
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

	// Token: 0x170000DC RID: 220
	// (get) Token: 0x0600118C RID: 4492 RVA: 0x00048440 File Offset: 0x00046640
	// (set) Token: 0x0600118D RID: 4493 RVA: 0x00048448 File Offset: 0x00046648
	public Guid AreaId
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

	// Token: 0x0600118E RID: 4494 RVA: 0x00048454 File Offset: 0x00046654
	public ar7()
	{
	}

	// Token: 0x0600118F RID: 4495 RVA: 0x00048460 File Offset: 0x00046660
	public ar7(b0b A_0)
	{
		if (A_0 != null && A_0.Area != null && A_0.Area.Zone != null && A_0.Area.Zone.Playfield != null)
		{
			base.a(new Guid?(A_0.qe()));
			this.c = A_0.Area.qe();
			this.b = A_0.Area.Zone.qe();
			this.a = A_0.Area.Zone.Playfield.Name;
			base.a(A_0);
		}
	}

	// Token: 0x06001190 RID: 4496 RVA: 0x00048504 File Offset: 0x00046704
	public ar7(Guid A_0, Guid A_1, Guid A_2, string A_3)
	{
		base.a(new Guid?(A_0));
		this.c = A_1;
		this.b = A_2;
		this.a = A_3;
	}

	// Token: 0x06001191 RID: 4497 RVA: 0x00048534 File Offset: 0x00046734
	public ar7(Guid A_0, aud A_1)
	{
		if (A_1 != null && A_1.Zone != null && A_1.Zone.Playfield != null)
		{
			base.a(new Guid?(A_0));
			this.c = A_1.qe();
			this.b = A_1.Zone.qe();
			this.a = A_1.Zone.Playfield.Name;
		}
	}

	// Token: 0x06001192 RID: 4498 RVA: 0x000485A8 File Offset: 0x000467A8
	public new void a(b0b A_0)
	{
		if (A_0 != null && A_0.Area != null && A_0.Area.Zone != null && A_0.Area.Zone.Playfield != null)
		{
			base.a(new Guid?(A_0.qe()));
			this.c = A_0.Area.qe();
			this.b = A_0.Area.Zone.qe();
			this.a = A_0.Area.Zone.Playfield.Name;
			base.a(A_0);
			return;
		}
		base.a(null);
		this.c = Guid.Empty;
		this.b = Guid.Empty;
		this.a = null;
		base.a(null);
	}

	// Token: 0x06001193 RID: 4499 RVA: 0x0004867C File Offset: 0x0004687C
	protected override b0b h4()
	{
		if (string.IsNullOrEmpty(this.a) || base.afl() == null)
		{
			return null;
		}
		d6j service = bpo.GetService<d6j>();
		if (service != null)
		{
			e3h e3h = service.dx(this.a);
			if (e3h != null)
			{
				c1a c1a = e3h.a(this.b);
				if (c1a != null)
				{
					aud aud = c1a.d(this.c);
					if (aud != null)
					{
						b0b b0b = aud.a(base.afl().Value);
						if (b0b == null)
						{
							foreach (aud aud2 in c1a.Areas)
							{
								if (aud2 != aud)
								{
									b0b = aud2.a(base.afl().Value);
									if (b0b != null)
									{
										break;
									}
								}
							}
						}
						return b0b;
					}
				}
			}
		}
		return null;
	}

	// Token: 0x040009E2 RID: 2530
	private string a;

	// Token: 0x040009E3 RID: 2531
	private Guid b;

	// Token: 0x040009E4 RID: 2532
	private Guid c;
}
