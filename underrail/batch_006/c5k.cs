using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;
using Ouroboros.Core.Logging;
using Ouroboros.Playfield.Design;

// Token: 0x0200027B RID: 635
[eiz("EB")]
[Serializable]
public sealed class c5k : ISerializable
{
	// Token: 0x0600128C RID: 4748 RVA: 0x0004D6FC File Offset: 0x0004B8FC
	private c5k(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.b = A_0.GetString("EB:N");
			this.c = (GeneralEntityCategory)A_0.GetValue("EB:GC", typeof(GeneralEntityCategory));
			this.d = A_0.GetString("EB:SC");
			this.e = A_0.GetString("EB:T");
			this.f = A_0.GetString("EB:P");
			this.g = (PropertyCollection)A_0.GetValue("EB:P1", typeof(PropertyCollection));
			return;
		}
		if (base.GetType() == typeof(c5k))
		{
			this.b = A_0.GetString("_Name");
			this.c = (GeneralEntityCategory)A_0.GetValue("_GeneralCategory", typeof(GeneralEntityCategory));
			this.d = A_0.GetString("_SubCategory");
			this.e = A_0.GetString("_Template");
			this.f = A_0.GetString("_Path");
			this.g = (PropertyCollection)A_0.GetValue("_Parameters", typeof(PropertyCollection));
			return;
		}
		this.b = A_0.GetString("EntityBlueprint+_Name");
		this.c = (GeneralEntityCategory)A_0.GetValue("EntityBlueprint+_GeneralCategory", typeof(GeneralEntityCategory));
		this.d = A_0.GetString("EntityBlueprint+_SubCategory");
		this.e = A_0.GetString("EntityBlueprint+_Template");
		this.f = A_0.GetString("EntityBlueprint+_Path");
		this.g = (PropertyCollection)A_0.GetValue("EntityBlueprint+_Parameters", typeof(PropertyCollection));
	}

	// Token: 0x0600128D RID: 4749 RVA: 0x0004D8CC File Offset: 0x0004BACC
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("EB:N", this.b);
		info.AddValue("EB:GC", this.c);
		info.AddValue("EB:SC", this.d);
		info.AddValue("EB:T", this.e);
		info.AddValue("EB:P", this.f);
		info.AddValue("EB:P1", this.g);
	}

	// Token: 0x0600128E RID: 4750 RVA: 0x0004D944 File Offset: 0x0004BB44
	public string d()
	{
		return this.b;
	}

	// Token: 0x0600128F RID: 4751 RVA: 0x0004D94C File Offset: 0x0004BB4C
	public void e(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001290 RID: 4752 RVA: 0x0004D958 File Offset: 0x0004BB58
	public GeneralEntityCategory b()
	{
		return this.c;
	}

	// Token: 0x06001291 RID: 4753 RVA: 0x0004D960 File Offset: 0x0004BB60
	public void a(GeneralEntityCategory A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06001292 RID: 4754 RVA: 0x0004D96C File Offset: 0x0004BB6C
	public string e()
	{
		return this.d;
	}

	// Token: 0x06001293 RID: 4755 RVA: 0x0004D974 File Offset: 0x0004BB74
	public void d(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06001294 RID: 4756 RVA: 0x0004D980 File Offset: 0x0004BB80
	public string g()
	{
		return this.e;
	}

	// Token: 0x06001295 RID: 4757 RVA: 0x0004D988 File Offset: 0x0004BB88
	public void b(string A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06001296 RID: 4758 RVA: 0x0004D994 File Offset: 0x0004BB94
	public string c()
	{
		return this.f;
	}

	// Token: 0x06001297 RID: 4759 RVA: 0x0004D99C File Offset: 0x0004BB9C
	public void f(string A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06001298 RID: 4760 RVA: 0x0004D9A8 File Offset: 0x0004BBA8
	public PropertyCollection f()
	{
		return this.g;
	}

	// Token: 0x06001299 RID: 4761 RVA: 0x0004D9B0 File Offset: 0x0004BBB0
	public void a(PropertyCollection A_0)
	{
		this.g = A_0;
	}

	// Token: 0x0600129A RID: 4762 RVA: 0x0004D9BC File Offset: 0x0004BBBC
	public c5k()
	{
	}

	// Token: 0x0600129B RID: 4763 RVA: 0x0004D9D0 File Offset: 0x0004BBD0
	public void c(string A_0)
	{
		czh.a(A_0, "filePath");
		eoq.SerializeToXmlFile<c5k>(A_0, this, null);
	}

	// Token: 0x0600129C RID: 4764 RVA: 0x0004D9E8 File Offset: 0x0004BBE8
	public static c5k a(string A_0)
	{
		czh.a(A_0, "filePath");
		return eoq.DeserializeFromXmlFile<c5k>(A_0, null);
	}

	// Token: 0x0600129D RID: 4765 RVA: 0x0004DA00 File Offset: 0x0004BC00
	public b0b a(Guid? A_0 = null, bool A_1 = false)
	{
		cvq service = bpo.GetService<cvq>();
		b0b result;
		try
		{
			d4x d4x = this.a();
			if (d4x == null)
			{
				throw new Exception("Failed to retrieve entity template for blueprint: " + this.b);
			}
			result = d4x.a(this, A_0, A_1);
		}
		catch (Exception ex)
		{
			if (service != null && service.n8() && service.n9(LogSeverity.Error, 112))
			{
				string a_ = string.Format("[Playfield] - Failed to create an entity instance from a blueprint '{0}'. Exception: '{1}'.", this.ToString(), ex.ToString());
				service.n7(LogSeverity.Error, 112, a_);
			}
			result = null;
		}
		return result;
	}

	// Token: 0x0600129E RID: 4766 RVA: 0x0004DAA0 File Offset: 0x0004BCA0
	public bool a(b0b A_0, List<string> A_1)
	{
		cvq service = bpo.GetService<cvq>();
		bool result;
		try
		{
			d4x d4x = this.a();
			if (d4x == null)
			{
				throw new Exception("Failed to retrieve entity template for blueprint: " + this.b);
			}
			result = d4x.a(this, A_0, A_1);
		}
		catch (Exception ex)
		{
			if (service != null && service.n8() && service.n9(LogSeverity.Error, 112))
			{
				string a_ = string.Format("[Playfield] - Failed to update an entity instance from a blueprint '{0}'. Exception: '{1}'.", this.ToString(), ex.ToString());
				service.n7(LogSeverity.Error, 112, a_);
			}
			result = false;
		}
		return result;
	}

	// Token: 0x0600129F RID: 4767 RVA: 0x0004DB40 File Offset: 0x0004BD40
	public T GetParam<T>(string paramName)
	{
		object propertyValue = this.f().GetPropertyValue(paramName);
		if (propertyValue is T)
		{
			return (T)((object)propertyValue);
		}
		return default(T);
	}

	// Token: 0x060012A0 RID: 4768 RVA: 0x0004DB78 File Offset: 0x0004BD78
	public override string ToString()
	{
		return string.Format("{0} ({1}{2})", this.b, this.c, string.IsNullOrEmpty(this.d) ? "" : ("." + this.d));
	}

	// Token: 0x060012A1 RID: 4769 RVA: 0x0004DBCC File Offset: 0x0004BDCC
	private d4x a()
	{
		return bpo.GetServiceOrThrow<d6j>().dv().c(this.e);
	}

	// Token: 0x04000A40 RID: 2624
	public const string a = "upeb";

	// Token: 0x04000A41 RID: 2625
	private string b;

	// Token: 0x04000A42 RID: 2626
	private GeneralEntityCategory c;

	// Token: 0x04000A43 RID: 2627
	private string d;

	// Token: 0x04000A44 RID: 2628
	private string e;

	// Token: 0x04000A45 RID: 2629
	private string f;

	// Token: 0x04000A46 RID: 2630
	private PropertyCollection g = new PropertyCollection();
}
