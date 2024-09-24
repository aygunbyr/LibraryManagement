using LibraryManagement.ConsoleUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.ConsoleUI.Repository;

public class MemberRepository : BaseRepository, IMemberRepository
{
    private List<Member> members;

    public MemberRepository()
    {
        members = Members();
    }

    public Member? Add(Member member)
    {
        members.Add(member);
        return member;
    }

    public List<Member> GetAll()
    {
        List<Member> orderedMembers = members.OrderBy(m => m.Id).ToList();
        return orderedMembers;
    }

    public Member? GetById(int id)
    {
        Member? member = members.FirstOrDefault(m => m.Id == id);
        return member;
    }

    public Member? Remove(int id)
    {
        Member? memberToBeDeleted = members.FirstOrDefault(m => m.Id == id);
        if (memberToBeDeleted != null)
        {
            members.Remove(memberToBeDeleted);
            return memberToBeDeleted;
        }
        return null;
    }

    public Member? Update(Member member)
    {
        Member? memberToBeUpdated = members.FirstOrDefault(m => m.Id == member.Id);
        if(memberToBeUpdated != null)
        {
            int index = members.IndexOf(memberToBeUpdated);
            members[index] = member;
        }
        return memberToBeUpdated;
    }
}