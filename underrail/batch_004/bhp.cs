using System;
using System.Runtime.Serialization;

// Token: 0x02000109 RID: 265
[eiz("WPB")]
[Serializable]
public class bhp : ISerializable
{
	// Token: 0x06000649 RID: 1609 RVA: 0x0001B150 File Offset: 0x00019350
	protected bhp(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetString("WPB:CN");
			this.b = A_0.GetString("WPB:PN");
			return;
		}
		if (base.GetType() == typeof(bhp))
		{
			this.a = A_0.GetString("_ContextName");
			this.b = A_0.GetString("_PropertyName");
			return;
		}
		this.a = A_0.GetString("WorkflowPropertyBinding+_ContextName");
		this.b = A_0.GetString("WorkflowPropertyBinding+_PropertyName");
	}

	// Token: 0x0600064A RID: 1610 RVA: 0x0001B1FC File Offset: 0x000193FC
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("WPB:CN", this.a);
		info.AddValue("WPB:PN", this.b);
	}

	// Token: 0x0600064B RID: 1611 RVA: 0x0001B220 File Offset: 0x00019420
	public string c()
	{
		return this.a;
	}

	// Token: 0x0600064C RID: 1612 RVA: 0x0001B228 File Offset: 0x00019428
	public void c(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600064D RID: 1613 RVA: 0x0001B234 File Offset: 0x00019434
	public string d()
	{
		return this.b;
	}

	// Token: 0x0600064E RID: 1614 RVA: 0x0001B23C File Offset: 0x0001943C
	public void b(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600064F RID: 1615 RVA: 0x0001B248 File Offset: 0x00019448
	public virtual bool ao7()
	{
		return !string.IsNullOrWhiteSpace(this.a) && !string.IsNullOrWhiteSpace(this.b);
	}

	// Token: 0x06000650 RID: 1616 RVA: 0x0001B26C File Offset: 0x0001946C
	public bhp()
	{
	}

	// Token: 0x06000651 RID: 1617 RVA: 0x0001B280 File Offset: 0x00019480
	public bhp(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06000652 RID: 1618 RVA: 0x0001B29C File Offset: 0x0001949C
	public bhp(string A_0, string A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06000653 RID: 1619 RVA: 0x0001B2C0 File Offset: 0x000194C0
	public object a(btm A_0)
	{
		if (A_0 != null && this.ao7())
		{
			ai ai = A_0.Root as ai;
			if (ai != null)
			{
				return ai.a(this.a, this.b);
			}
		}
		return null;
	}

	// Token: 0x06000654 RID: 1620 RVA: 0x0001B304 File Offset: 0x00019504
	public T GetValue<T>(btm declaringActivity)
	{
		object obj = this.a(declaringActivity);
		if (obj != null && obj is T)
		{
			return (T)((object)obj);
		}
		return default(T);
	}

	// Token: 0x06000655 RID: 1621 RVA: 0x0001B33C File Offset: 0x0001953C
	public void SetValue<T>(btm declaringActivity, T value)
	{
		if (declaringActivity != null && this.ao7())
		{
			ai ai = declaringActivity.Root as ai;
			if (ai != null)
			{
				ai.a(this.a, this.b, value);
			}
		}
	}

	// Token: 0x06000656 RID: 1622 RVA: 0x0001B384 File Offset: 0x00019584
	public void c(btm A_0, object A_1)
	{
		this.SetValue<object>(A_0, A_1);
	}

	// Token: 0x06000657 RID: 1623 RVA: 0x0001B390 File Offset: 0x00019590
	public override string ToString()
	{
		return ((!this.ao7()) ? "[Unbound]" : "") + this.a + "." + this.b;
	}

	// Token: 0x0400050F RID: 1295
	private string a = ddb.a;

	// Token: 0x04000510 RID: 1296
	private string b;
}
