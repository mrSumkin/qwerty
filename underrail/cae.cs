using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000227 RID: 551
[eiz("E2")]
[Serializable]
public abstract class cae : c7t, a9q, ISerializable
{
	// Token: 0x06000F50 RID: 3920 RVA: 0x000401F8 File Offset: 0x0003E3F8
	protected cae(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = (Guid)A_0.GetValue("E2:I", typeof(Guid));
			this.b = A_0.GetString("E2:N");
			return;
		}
		this.a = (Guid)A_0.GetValue("_Id", typeof(Guid));
		this.b = A_0.GetString("_Name");
	}

	// Token: 0x06000F51 RID: 3921 RVA: 0x00040278 File Offset: 0x0003E478
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("E2:I", this.a);
		info.AddValue("E2:N", this.b);
	}

	// Token: 0x06000F52 RID: 3922 RVA: 0x000402A4 File Offset: 0x0003E4A4
	public Guid qe()
	{
		return this.a;
	}

	// Token: 0x06000F53 RID: 3923 RVA: 0x000402AC File Offset: 0x0003E4AC
	internal void h(Guid A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000F54 RID: 3924 RVA: 0x000402B8 File Offset: 0x0003E4B8
	public string y8()
	{
		return this.b;
	}

	// Token: 0x06000F55 RID: 3925 RVA: 0x000402C0 File Offset: 0x0003E4C0
	public void q(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06000F56 RID: 3926 RVA: 0x000402CC File Offset: 0x0003E4CC
	protected cae(Guid A_0, string A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06000F57 RID: 3927 RVA: 0x000402E8 File Offset: 0x0003E4E8
	public string r(string A_0)
	{
		string a_;
		List<string> a_2;
		cae.a(A_0, out a_, out a_2);
		return this.a(a_, a_2);
	}

	// Token: 0x06000F58 RID: 3928 RVA: 0x00040308 File Offset: 0x0003E508
	public string a(string A_0, params string[] A_1)
	{
		return this.a(A_0 ?? string.Empty, new List<string>(A_1 ?? new string[0]));
	}

	// Token: 0x06000F59 RID: 3929 RVA: 0x00040330 File Offset: 0x0003E530
	public void i(Guid A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000F5A RID: 3930 RVA: 0x0004033C File Offset: 0x0003E53C
	private static void a(string A_0, out string A_1, out List<string> A_2)
	{
		A_2 = new List<string>();
		A_1 = "";
		if (!string.IsNullOrEmpty(A_0))
		{
			string[] array = A_0.Split(new char[]
			{
				' '
			}, StringSplitOptions.RemoveEmptyEntries);
			if (array.Length != 0)
			{
				A_1 = array[0];
				A_2 = new List<string>();
				if (array.Length > 1)
				{
					for (int i = 1; i < array.Length; i++)
					{
						A_2.Add(array[i]);
					}
				}
			}
		}
	}

	// Token: 0x06000F5B RID: 3931 RVA: 0x000403B4 File Offset: 0x0003E5B4
	protected virtual string a(string A_0, List<string> A_1)
	{
		return string.Empty;
	}

	// Token: 0x04000924 RID: 2340
	protected Guid a;

	// Token: 0x04000925 RID: 2341
	protected string b;
}
