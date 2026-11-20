using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x02000274 RID: 628
[eiz("ZL")]
[Serializable]
public sealed class doq : ISerializable
{
	// Token: 0x06001268 RID: 4712 RVA: 0x0004CB5C File Offset: 0x0004AD5C
	private doq(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.b = (Guid)A_0.GetValue("ZL:ZI", typeof(Guid));
			di7.ReadList<ego>("ZL:SLE", ref this.c, A_0);
			di7.ReadList<ah7>("ZL:LD", ref this.d, A_0);
			di7.ReadList<cpe>("ZL:AL", ref this.e, A_0);
			di7.ReadList<csd>("ZL:W", ref this.f, A_0);
			if (ell.b() >= 8)
			{
				this.g = (A_0.GetValue("ZL:CP", typeof(PropertyCollection)) as PropertyCollection);
				return;
			}
			this.g = new PropertyCollection();
			return;
		}
		else
		{
			if (base.GetType() == typeof(doq))
			{
				this.b = (Guid)A_0.GetValue("_ZoneId", typeof(Guid));
				this.c = (List<ego>)A_0.GetValue("_SoftLightEmitters", typeof(List<ego>));
				this.d = (List<ah7>)A_0.GetValue("_LanternDefinitions", typeof(List<ah7>));
				this.e = (List<cpe>)A_0.GetValue("_AreaLayers", typeof(List<cpe>));
				this.f = (List<csd>)A_0.GetValue("_Waypoints", typeof(List<csd>));
				return;
			}
			this.b = (Guid)A_0.GetValue("ZoneLayer+_ZoneId", typeof(Guid));
			this.c = (List<ego>)A_0.GetValue("ZoneLayer+_SoftLightEmitters", typeof(List<ego>));
			this.d = (List<ah7>)A_0.GetValue("ZoneLayer+_LanternDefinitions", typeof(List<ah7>));
			this.e = (List<cpe>)A_0.GetValue("ZoneLayer+_AreaLayers", typeof(List<cpe>));
			this.f = (List<csd>)A_0.GetValue("ZoneLayer+_Waypoints", typeof(List<csd>));
			return;
		}
	}

	// Token: 0x06001269 RID: 4713 RVA: 0x0004CDA8 File Offset: 0x0004AFA8
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("ZL:ZI", this.b);
		di7.WriteList<ego>("ZL:SLE", this.c, info);
		di7.WriteList<ah7>("ZL:LD", this.d, info);
		di7.WriteList<cpe>("ZL:AL", this.e, info);
		di7.WriteList<csd>("ZL:W", this.f, info);
		info.AddValue("ZL:CP", this.g);
	}

	// Token: 0x0600126A RID: 4714 RVA: 0x0004CE20 File Offset: 0x0004B020
	public Guid c()
	{
		return this.b;
	}

	// Token: 0x0600126B RID: 4715 RVA: 0x0004CE28 File Offset: 0x0004B028
	public List<ego> f()
	{
		return this.c;
	}

	// Token: 0x0600126C RID: 4716 RVA: 0x0004CE30 File Offset: 0x0004B030
	public List<ah7> b()
	{
		return this.d;
	}

	// Token: 0x0600126D RID: 4717 RVA: 0x0004CE38 File Offset: 0x0004B038
	public List<cpe> e()
	{
		return this.e;
	}

	// Token: 0x0600126E RID: 4718 RVA: 0x0004CE40 File Offset: 0x0004B040
	public List<csd> d()
	{
		return this.f;
	}

	// Token: 0x0600126F RID: 4719 RVA: 0x0004CE48 File Offset: 0x0004B048
	public bool g()
	{
		return this.c.Count == 0 && this.d.Count == 0 && this.e.Count == 0;
	}

	// Token: 0x06001270 RID: 4720 RVA: 0x0004CE7C File Offset: 0x0004B07C
	public PropertyCollection a()
	{
		return this.g;
	}

	// Token: 0x06001271 RID: 4721 RVA: 0x0004CE84 File Offset: 0x0004B084
	public doq()
	{
	}

	// Token: 0x06001272 RID: 4722 RVA: 0x0004CEC4 File Offset: 0x0004B0C4
	public void b(string A_0)
	{
		czh.a(A_0, "filePath");
		eoq.SerializeToBinaryFileCompressed<doq>(A_0, this, dds.a(), eh9.c, true);
	}

	// Token: 0x06001273 RID: 4723 RVA: 0x0004CEE4 File Offset: 0x0004B0E4
	public static doq a(string A_0)
	{
		czh.a(A_0, "filePath");
		return eoq.DeserializeFromBinaryFileCompressed<doq>(A_0, dds.a(), true);
	}

	// Token: 0x06001274 RID: 4724 RVA: 0x0004CF00 File Offset: 0x0004B100
	public static doq a(c1a A_0, int A_1, bool A_2)
	{
		czh.a(A_0, "zone");
		doq doq = new doq();
		doq.b = A_0.qe();
		foreach (ego ego in new List<ego>(A_0.SoftLightEmitters))
		{
			if (ego.Layer == A_1)
			{
				doq.f().Add(ego);
				A_0.a(ego);
			}
		}
		foreach (ah7 ah in new List<ah7>(A_0.LanternDefinitions))
		{
			if (ah.Layer == A_1)
			{
				doq.b().Add(ah);
				A_0.b(ah);
			}
		}
		foreach (csd csd in new List<csd>(A_0.Waypoints))
		{
			if (csd.Layer == A_1)
			{
				A_0.b(csd);
				doq.d().Add(csd);
			}
		}
		foreach (aud a_ in A_0.Areas)
		{
			cpe cpe = cpe.a(a_, A_1);
			if (!cpe.IsEmpty || !A_2)
			{
				doq.e().Add(cpe);
			}
		}
		if (A_0.CustomProperties != null)
		{
			foreach (Property property in Enumerable.ToList<Property>(A_0.CustomProperties.Properties))
			{
				if (!string.IsNullOrEmpty(property.Name) && property.Name.StartsWith("Layered|"))
				{
					string[] array = property.Name.Split(new string[]
					{
						"|"
					}, StringSplitOptions.RemoveEmptyEntries);
					if (array.Length == 3)
					{
						int num;
						int.TryParse(array[1], NumberStyles.Number, CultureInfo.InvariantCulture, out num);
						if (num == A_1)
						{
							doq.a().SetPropertyValue(property.Name, property.Value);
							A_0.CustomProperties.RemoveProperty(property.Name);
						}
					}
				}
			}
		}
		return doq;
	}

	// Token: 0x06001275 RID: 4725 RVA: 0x0004D1C8 File Offset: 0x0004B3C8
	public static doq a(c1a A_0, int A_1, List<afo> A_2)
	{
		czh.a(A_0, "zone");
		doq doq = new doq();
		doq.b = A_0.qe();
		foreach (ego ego in new List<ego>(A_0.SoftLightEmitters))
		{
			ego.Layer;
		}
		foreach (ah7 ah in new List<ah7>(A_0.LanternDefinitions))
		{
			ah.Layer;
		}
		foreach (csd csd in new List<csd>(A_0.Waypoints))
		{
			csd.Layer;
		}
		foreach (aud a_ in A_0.Areas)
		{
			cpe item = cpe.a(a_, A_1, A_2);
			doq.e().Add(item);
		}
		if (A_0.CustomProperties != null)
		{
			foreach (Property property in Enumerable.ToList<Property>(A_0.CustomProperties.Properties))
			{
				if (!string.IsNullOrEmpty(property.Name) && property.Name.StartsWith("Layered|"))
				{
					string[] array = property.Name.Split(new string[]
					{
						"|"
					}, StringSplitOptions.RemoveEmptyEntries);
					if (array.Length == 3)
					{
						int num;
						int.TryParse(array[1], NumberStyles.Number, CultureInfo.InvariantCulture, out num);
						if (num == A_1)
						{
							doq.a().SetPropertyValue(property.Name, property.Value);
						}
					}
				}
			}
		}
		return doq;
	}

	// Token: 0x04000A32 RID: 2610
	public const string a = "uzl";

	// Token: 0x04000A33 RID: 2611
	private Guid b;

	// Token: 0x04000A34 RID: 2612
	private List<ego> c = new List<ego>();

	// Token: 0x04000A35 RID: 2613
	private List<ah7> d = new List<ah7>();

	// Token: 0x04000A36 RID: 2614
	private List<cpe> e = new List<cpe>();

	// Token: 0x04000A37 RID: 2615
	private List<csd> f = new List<csd>();

	// Token: 0x04000A38 RID: 2616
	private PropertyCollection g = new PropertyCollection();
}
