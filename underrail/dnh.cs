using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x0200014C RID: 332
[eiz("C")]
[Serializable]
public abstract class dnh : ISerializable, c7m, dth
{
	// Token: 0x06000832 RID: 2098 RVA: 0x00022990 File Offset: 0x00020B90
	protected dnh(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetString("C:N");
			return;
		}
		if (base.GetType() == typeof(dnh))
		{
			this.a = A_0.GetString("_Name");
			return;
		}
		this.a = A_0.GetString("Condition+_Name");
	}

	// Token: 0x06000833 RID: 2099 RVA: 0x000229FC File Offset: 0x00020BFC
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("C:N", this.a);
	}

	// Token: 0x06000834 RID: 2100 RVA: 0x00022A10 File Offset: 0x00020C10
	public string h()
	{
		return this.a;
	}

	// Token: 0x06000835 RID: 2101 RVA: 0x00022A18 File Offset: 0x00020C18
	public void d(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000836 RID: 2102 RVA: 0x00022A24 File Offset: 0x00020C24
	protected dnh()
	{
	}

	// Token: 0x06000837 RID: 2103
	public abstract bool cw(bq8 A_0, bq8 A_1);

	// Token: 0x06000838 RID: 2104 RVA: 0x00022A2C File Offset: 0x00020C2C
	public virtual bool h5(string A_0, bool A_1)
	{
		return !string.IsNullOrEmpty(this.a) && this.a.IndexOf(A_0, A_1 ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase) != -1;
	}

	// Token: 0x06000839 RID: 2105 RVA: 0x00022A60 File Offset: 0x00020C60
	public bool jh(object A_0)
	{
		abd serviceOrThrow = bpo.GetServiceOrThrow<abd>();
		return this.cw(serviceOrThrow.ary(), new PropertyCollection());
	}

	// Token: 0x0600083A RID: 2106 RVA: 0x00022A84 File Offset: 0x00020C84
	public string ji()
	{
		return this.ToString();
	}

	// Token: 0x040005A1 RID: 1441
	private string a;
}
