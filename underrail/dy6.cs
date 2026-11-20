using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001B47 RID: 6983
[eiz("CGC")]
[Serializable]
public sealed class dy6 : dth, ISerializable
{
	// Token: 0x06009702 RID: 38658 RVA: 0x003AFC58 File Offset: 0x003ADE58
	private dy6(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (Gender)A_0.GetValue("CGC:G", typeof(Gender));
	}

	// Token: 0x06009703 RID: 38659 RVA: 0x003AFC80 File Offset: 0x003ADE80
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("CGC:G", this.a);
	}

	// Token: 0x06009704 RID: 38660 RVA: 0x003AFC98 File Offset: 0x003ADE98
	public Gender a()
	{
		return this.a;
	}

	// Token: 0x06009705 RID: 38661 RVA: 0x003AFCA0 File Offset: 0x003ADEA0
	public void a(Gender A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06009706 RID: 38662 RVA: 0x003AFCAC File Offset: 0x003ADEAC
	public dy6()
	{
	}

	// Token: 0x06009707 RID: 38663 RVA: 0x003AFCB4 File Offset: 0x003ADEB4
	public dy6(Gender A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06009708 RID: 38664 RVA: 0x003AFCC4 File Offset: 0x003ADEC4
	public bool jh(object A_0)
	{
		ll ll = A_0 as ll;
		return ll != null && ll.a() != null && ll.a().Gender == this.a;
	}

	// Token: 0x06009709 RID: 38665 RVA: 0x003AFD00 File Offset: 0x003ADF00
	public string ji()
	{
		return string.Format("Действует только на персонажей {0} пола", this.a.ToString().ToLowerInvariant());
	}

	// Token: 0x04003A19 RID: 14873
	private Gender a;
}
