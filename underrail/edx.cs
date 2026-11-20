using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Data;

// Token: 0x02000265 RID: 613
[eiz("TR")]
[Serializable]
public sealed class edx : TypedObjectReference<ak1>, ISerializable
{
	// Token: 0x06001224 RID: 4644 RVA: 0x0004AC2C File Offset: 0x00048E2C
	private edx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetString("TR:PN");
			this.b = (Guid)A_0.GetValue("TR:ZI", typeof(Guid));
			this.c = (Guid)A_0.GetValue("TR:AI", typeof(Guid));
			this.d = (Point)A_0.GetValue("TR:TL", typeof(Point));
			return;
		}
		if (base.GetType() == typeof(edx))
		{
			this.a = A_0.GetString("_PlayfieldName");
			this.b = (Guid)A_0.GetValue("_ZoneId", typeof(Guid));
			this.c = (Guid)A_0.GetValue("_AreaId", typeof(Guid));
			this.d = (Point)A_0.GetValue("_TileLocation", typeof(Point));
			return;
		}
		this.a = A_0.GetString("TileReference+_PlayfieldName");
		this.b = (Guid)A_0.GetValue("TileReference+_ZoneId", typeof(Guid));
		this.c = (Guid)A_0.GetValue("TileReference+_AreaId", typeof(Guid));
		this.d = (Point)A_0.GetValue("TileReference+_TileLocation", typeof(Point));
	}

	// Token: 0x06001225 RID: 4645 RVA: 0x0004ADBC File Offset: 0x00048FBC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TR:PN", this.a);
		info.AddValue("TR:ZI", this.b);
		info.AddValue("TR:AI", this.c);
		info.AddValue("TR:TL", this.d);
	}

	// Token: 0x06001226 RID: 4646 RVA: 0x0004AE24 File Offset: 0x00049024
	public edx(ak1 A_0)
	{
		if (A_0 != null && A_0.Area != null && A_0.Zone != null && A_0.Zone.Playfield != null)
		{
			this.d = A_0.Location;
			this.c = A_0.Area.qe();
			this.b = A_0.Area.Zone.qe();
			this.a = A_0.Area.Zone.Playfield.Name;
			base.a(A_0);
		}
	}

	// Token: 0x06001227 RID: 4647 RVA: 0x0004AEB8 File Offset: 0x000490B8
	protected override ak1 h4()
	{
		if (string.IsNullOrEmpty(this.a))
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
						return aud.b(this.d.X, this.d.Y);
					}
				}
			}
		}
		return null;
	}

	// Token: 0x04000A10 RID: 2576
	private string a;

	// Token: 0x04000A11 RID: 2577
	private Guid b;

	// Token: 0x04000A12 RID: 2578
	private Guid c;

	// Token: 0x04000A13 RID: 2579
	private Point d;
}
