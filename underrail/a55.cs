using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x02000262 RID: 610
[eiz("ZR")]
[Serializable]
public sealed class a55 : TypedObjectReference<c1a>, ISerializable
{
	// Token: 0x06001182 RID: 4482 RVA: 0x0004814C File Offset: 0x0004634C
	private a55(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetString("ZR:PN");
			return;
		}
		if (base.GetType() == typeof(a55))
		{
			this.a = A_0.GetString("_PlayfieldName");
			return;
		}
		this.a = A_0.GetString("ZoneReference+_PlayfieldName");
	}

	// Token: 0x06001183 RID: 4483 RVA: 0x000481BC File Offset: 0x000463BC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ZR:PN", this.a);
	}

	// Token: 0x06001184 RID: 4484 RVA: 0x000481DC File Offset: 0x000463DC
	public a55(c1a A_0)
	{
		if (A_0 != null && A_0.Playfield != null)
		{
			base.a(new Guid?(A_0.qe()));
			this.a = A_0.Playfield.Name;
			base.a(A_0);
		}
	}

	// Token: 0x06001185 RID: 4485 RVA: 0x0004822C File Offset: 0x0004642C
	protected override c1a h4()
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
				return e3h.a(base.afl().Value);
			}
		}
		return null;
	}

	// Token: 0x040009E1 RID: 2529
	private string a;
}
