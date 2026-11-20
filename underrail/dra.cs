using System;
using System.Runtime.Serialization;
using Ouroboros.Core.Logging;

// Token: 0x020004BD RID: 1213
[eiz("WPBB")]
[Serializable]
public class dra : bhp, ISerializable
{
	// Token: 0x06001EFF RID: 7935 RVA: 0x000ABD9C File Offset: 0x000A9F9C
	protected dra(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("WPBB:EPP");
			this.b = (bqe)A_0.GetValue("WPBB:D", typeof(bqe));
			return;
		}
		if (base.GetType() == typeof(dra))
		{
			this.a = A_0.GetString("_ExternalPropertyPath");
			this.b = (bqe)A_0.GetValue("_Direction", typeof(bqe));
			return;
		}
		this.a = A_0.GetString("WorkflowPropertyBridgeBinding+_ExternalPropertyPath");
		this.b = (bqe)A_0.GetValue("WorkflowPropertyBridgeBinding+_Direction", typeof(bqe));
	}

	// Token: 0x06001F00 RID: 7936 RVA: 0x000ABE6C File Offset: 0x000AA06C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("WPBB:EPP", this.a);
		info.AddValue("WPBB:D", this.b);
	}

	// Token: 0x06001F01 RID: 7937 RVA: 0x000ABEA0 File Offset: 0x000AA0A0
	public string a()
	{
		return this.a;
	}

	// Token: 0x06001F02 RID: 7938 RVA: 0x000ABEA8 File Offset: 0x000AA0A8
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001F03 RID: 7939 RVA: 0x000ABEB4 File Offset: 0x000AA0B4
	public override bool ao7()
	{
		return base.ao7() && !string.IsNullOrWhiteSpace(this.a);
	}

	// Token: 0x06001F04 RID: 7940 RVA: 0x000ABED4 File Offset: 0x000AA0D4
	public bqe b()
	{
		return this.b;
	}

	// Token: 0x06001F05 RID: 7941 RVA: 0x000ABEDC File Offset: 0x000AA0DC
	public void a(bqe A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001F06 RID: 7942 RVA: 0x000ABEE8 File Offset: 0x000AA0E8
	public dra()
	{
	}

	// Token: 0x06001F07 RID: 7943 RVA: 0x000ABEF0 File Offset: 0x000AA0F0
	public dra(string A_0, string A_1) : base(A_1)
	{
		this.a = A_0;
	}

	// Token: 0x06001F08 RID: 7944 RVA: 0x000ABF00 File Offset: 0x000AA100
	public dra(string A_0, string A_1, string A_2) : base(A_1, A_2)
	{
		this.a = A_0;
	}

	// Token: 0x06001F09 RID: 7945 RVA: 0x000ABF14 File Offset: 0x000AA114
	public void b(btm A_0, object A_1)
	{
		if (this.b != bqe.b && this.ao7() && A_0 != null && A_1 != null)
		{
			try
			{
				object a_ = base.a(A_0);
				boo.a(A_1, this.a, a_);
			}
			catch (Exception a_2)
			{
				dux.a(LogSeverity.Error, a_2, "Error occured while exporting bridge bound workflow property '{0}'.", new object[]
				{
					this.ToString()
				});
			}
		}
	}

	// Token: 0x06001F0A RID: 7946 RVA: 0x000ABF90 File Offset: 0x000AA190
	public void a(btm A_0, object A_1)
	{
		if (this.b != bqe.c && this.ao7() && A_0 != null && A_1 != null)
		{
			try
			{
				object a_ = boo.a(A_1, this.a);
				base.c(A_0, a_);
			}
			catch (Exception a_2)
			{
				dux.a(LogSeverity.Error, a_2, "Error occured while importing bridge bound workflow property '{0}'.", new object[]
				{
					this.ToString()
				});
			}
		}
	}

	// Token: 0x06001F0B RID: 7947 RVA: 0x000AC00C File Offset: 0x000AA20C
	public override string ToString()
	{
		return base.ToString() + " <-> " + this.a;
	}

	// Token: 0x040013A5 RID: 5029
	private new string a;

	// Token: 0x040013A6 RID: 5030
	private bqe b;
}
