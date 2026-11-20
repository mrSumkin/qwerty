using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x0200025F RID: 607
[eiz("AR")]
[Serializable]
public sealed class e6z : TypedObjectReference<aud>, ISerializable
{
	// Token: 0x0600116E RID: 4462 RVA: 0x00047C6C File Offset: 0x00045E6C
	private e6z(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetString("AR:PN");
			this.b = (Guid?)A_0.GetValue("AR:ZI", typeof(Guid?));
			return;
		}
		if (base.GetType() == typeof(e6z))
		{
			this.a = A_0.GetString("_PlayfieldName");
			this.b = (Guid?)A_0.GetValue("_ZoneId", typeof(Guid?));
			return;
		}
		this.a = A_0.GetString("AreaReference+_PlayfieldName");
		this.b = (Guid?)A_0.GetValue("AreaReference+_ZoneId", typeof(Guid?));
	}

	// Token: 0x0600116F RID: 4463 RVA: 0x00047D3C File Offset: 0x00045F3C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("AR:PN", this.a);
		info.AddValue("AR:ZI", this.b);
	}

	// Token: 0x06001170 RID: 4464 RVA: 0x00047D70 File Offset: 0x00045F70
	public e6z(aud A_0)
	{
		if (A_0 != null && A_0.Zone != null)
		{
			base.a(new Guid?(A_0.qe()));
			this.b = new Guid?(A_0.Zone.qe());
			this.a = ((A_0.Zone.Playfield != null) ? A_0.Zone.Playfield.Name : null);
			base.a(A_0);
		}
	}

	// Token: 0x06001171 RID: 4465 RVA: 0x00047DF0 File Offset: 0x00045FF0
	public e6z(Guid A_0, Guid A_1, string A_2)
	{
		base.a(new Guid?(A_0));
		this.b = new Guid?(A_1);
		this.a = A_2;
	}

	// Token: 0x06001172 RID: 4466 RVA: 0x00047E1C File Offset: 0x0004601C
	protected override aud h4()
	{
		if (this.b == null || base.afl() == null)
		{
			return null;
		}
		d6j service = bpo.GetService<d6j>();
		if (service != null)
		{
			e3h e3h;
			if (!string.IsNullOrEmpty(this.a))
			{
				e3h = service.dx(this.a);
			}
			else
			{
				e3h = service.dy();
			}
			if (e3h != null)
			{
				c1a c1a = e3h.a(this.b.Value);
				if (c1a != null)
				{
					return c1a.d(base.afl().Value);
				}
			}
		}
		return null;
	}

	// Token: 0x040009DA RID: 2522
	private string a;

	// Token: 0x040009DB RID: 2523
	private Guid? b;
}
