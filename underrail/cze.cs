using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x0200054D RID: 1357
[eiz("J1")]
[Serializable]
public abstract class cze : ISerializable
{
	// Token: 0x060022BA RID: 8890 RVA: 0x000B8050 File Offset: 0x000B6250
	protected cze(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("J1:N");
			return;
		}
		if (base.GetType() == typeof(cze))
		{
			this.a = A_0.GetString("_Name");
			return;
		}
		this.a = A_0.GetString("Job+_Name");
	}

	// Token: 0x060022BB RID: 8891 RVA: 0x000B80BC File Offset: 0x000B62BC
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("J1:N", this.a);
	}

	// Token: 0x17000111 RID: 273
	// (get) Token: 0x060022BC RID: 8892 RVA: 0x000B80D0 File Offset: 0x000B62D0
	// (set) Token: 0x060022BD RID: 8893 RVA: 0x000B80D8 File Offset: 0x000B62D8
	[Browsable(false)]
	public string Name
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

	// Token: 0x060022BE RID: 8894
	public abstract void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2);

	// Token: 0x060022BF RID: 8895 RVA: 0x000B80E4 File Offset: 0x000B62E4
	public override string ToString()
	{
		if (!string.IsNullOrEmpty(this.a))
		{
			return string.Format("{0} : {1}", this.a, base.GetType().Name);
		}
		return base.GetType().Name;
	}

	// Token: 0x060022C0 RID: 8896 RVA: 0x000B8128 File Offset: 0x000B6328
	public static aud a(string A_0, b0b A_1, b0b A_2, Dictionary<string, object> A_3)
	{
		aud result = null;
		object obj2;
		if (!string.IsNullOrEmpty(A_0))
		{
			c1a c1a = null;
			object obj;
			if (A_3 != null && A_3.TryGetValue("zone", out obj))
			{
				c1a = (obj as c1a);
			}
			if (c1a == null)
			{
				if (A_2 != null && A_2.Zone != null)
				{
					c1a = A_2.Zone;
				}
				else if (A_1 != null)
				{
					c1a = A_1.Zone;
				}
			}
			if (c1a == null)
			{
				b4b service = bpo.GetService<b4b>();
				if (service != null && service.yn() != null)
				{
					c1a = Enumerable.FirstOrDefault<c1a>(service.yn().Zones);
				}
			}
			if (c1a != null)
			{
				result = c1a.n(A_0);
			}
		}
		else if (A_2 != null && A_2.Area != null)
		{
			result = A_2.Area;
		}
		else if (A_1 != null && A_1.Area != null)
		{
			result = A_1.Area;
		}
		else if (A_3.TryGetValue("area", out obj2))
		{
			result = (obj2 as aud);
		}
		return result;
	}

	// Token: 0x060022C1 RID: 8897 RVA: 0x000B822C File Offset: 0x000B642C
	public static cxz a(string A_0)
	{
		return new cxz(A_0);
	}

	// Token: 0x060022C2 RID: 8898 RVA: 0x000B8234 File Offset: 0x000B6434
	protected cze()
	{
	}

	// Token: 0x04001486 RID: 5254
	private string a;
}
