using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000FDE RID: 4062
[eiz("EJA")]
[Serializable]
public sealed class b6e : esc, ISerializable
{
	// Token: 0x060053A5 RID: 21413 RVA: 0x002511F4 File Offset: 0x0024F3F4
	private b6e(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (cze)A_0.GetValue("EJA:J", typeof(cze));
			return;
		}
		if (base.GetType() == typeof(b6e))
		{
			this.a = (cze)A_0.GetValue("_Job", typeof(cze));
			return;
		}
		this.a = (cze)A_0.GetValue("ExecuteJobAction+_Job", typeof(cze));
	}

	// Token: 0x060053A6 RID: 21414 RVA: 0x00251290 File Offset: 0x0024F490
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("EJA:J", this.a);
	}

	// Token: 0x060053A7 RID: 21415 RVA: 0x002512AC File Offset: 0x0024F4AC
	public cze a()
	{
		return this.a;
	}

	// Token: 0x060053A8 RID: 21416 RVA: 0x002512B4 File Offset: 0x0024F4B4
	public void a(cze A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060053A9 RID: 21417 RVA: 0x002512C0 File Offset: 0x0024F4C0
	public override int d5(bq8 A_0, bq8 A_1)
	{
		if (this.a != null)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			if (A_1 != null)
			{
				dictionary["tempcontext"] = A_1;
			}
			this.a.ym(A_0.get_Item(c49.a) as b0b, A_0.get_Item(c49.b) as b0b, dictionary);
		}
		return 1;
	}

	// Token: 0x060053AA RID: 21418 RVA: 0x00251320 File Offset: 0x0024F520
	public b6e()
	{
	}

	// Token: 0x060053AB RID: 21419 RVA: 0x00251328 File Offset: 0x0024F528
	public b6e(cze A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060053AC RID: 21420 RVA: 0x00251338 File Offset: 0x0024F538
	public override bool h5(string A_0, bool A_1)
	{
		if (!base.h5(A_0, A_1) && this.a != null)
		{
			string text = this.a.ToString();
			if (!string.IsNullOrEmpty(text) && text.IndexOf(A_0, A_1 ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase) != -1)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0400221B RID: 8731
	private cze a;
}
